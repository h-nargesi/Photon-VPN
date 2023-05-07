using Microsoft.EntityFrameworkCore;

namespace Photon.Service.VPN.Models
{
    public class PlanBusiness : IDisposable
    {
        public const string SimpleAdd = "SimpleAdd_";

        public const string Simultaneous_Use = "Simultaneous-Use";

        private readonly RdContext db;

        public PlanBusiness()
        {
            db = new RdContext();
        }

        public async Task<Plan> Save(Plan plan)
        {
            plan = await SavePlan(plan);

            await SavePackages(plan);
            await SaveCheckes(plan);
            await SaveReplies(plan);
            
            return plan;
        }

        private async Task<Plan> SavePlan(Plan plan)
        {
            var original = await db.Plans.AsNoTracking()
                                         .Include(p => p.Packages)
                                         .Where(c => c.Id == plan.Id)
                                         .FirstOrDefaultAsync();

            if (original == null)
            {
                original = plan;

                plan.Created = plan.Modified = DateTime.Now;

                await db.Plans.AddAsync(plan);
            }
            else
            {
                plan.Modified = DateTime.Now;

                db.Plans.Attach(original);
                db.Entry(original).CurrentValues.SetValues(plan);
                db.Entry(original).Property(x => x.Created).IsModified = false;
            }

            await db.SaveChangesAsync();

            return original;
        }

        private Task SavePackages(Plan plan)
        {
            plan.Packages.Clear();
            foreach (var pr in plan.Profiles)
                plan.Packages.Add(new Package
                {
                    PlanId = plan.Id,
                    ProfileId = pr.Id,
                });

            return db.SaveChangesAsync();
        }

        private Task SaveCheckes(Plan plan)
        {
            foreach (var check in plan.Checks)
            {
                // save check
            }

            return Task.CompletedTask;
        }

        private Task SaveReplies(Plan plan)
        {
            foreach (var check in plan.Replies)
            {
                // save replies
            }

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
