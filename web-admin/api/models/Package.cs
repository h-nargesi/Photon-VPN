namespace Photon.Service.VPN.Handlers.Model;

public class PackageModel
{
    public int PlanId { get; set; }

    public int ProfileId { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public decimal Price { get; set; }

    public string? ImageFile { get; set; }

    public int Color { get; set; }

    public string? Description { get; set; }

    public DateTime Created { get; set; }

    public DateTime Modified { get; set; }

}