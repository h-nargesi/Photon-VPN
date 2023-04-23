use rd;

drop table if exists accounts;
drop table if exists users_access;
drop table if exists permanent_user_logs;
drop table if exists permanent_user_plan;
drop table if exists plans;
drop table if exists payments;

create table payments (
	id					int				not null	auto_increment,
	permanent_user_id	int				not null,
	approved			tinyint(1)		not null	default 0,
	
	value				decimal(16)		not null,
	trnsaction_id		varchar(24)		not null,
	date_time			datetime		not null	default current_timestamp,
	bank_name			varchar(255)	not null,
	bank_account		varchar(255)	not null,

	register_time		datetime		not null	default current_timestamp,

	primary key (id),
	foreign key (permanent_user_id) references permanent_users (id) on delete cascade
);

create table plans (
	profile_id			int				not null,
	active				tinyint(1)		not null	default 1,

	price				decimal(16)		not null,
	image_file			text				null,
	color				int				not null	default 0,
	description			text				null,
	
	register_time		datetime		not null	default current_timestamp,
	modification_time	datetime		not null	on update current_timestamp,

	primary key (profile_id),
	foreign key (profile_id) references profiles (id) on delete cascade
);

create table permanent_user_plan (
	permanent_user_id	int				not null,
	valid_time			datetime		not null,
	profile_id			int				not null,
	override_price		decimal(16)			null,
	register_time		datetime		not null	default current_timestamp,
	
	primary key (permanent_user_id, valid_time),
	foreign key (permanent_user_id) references permanent_users (id) on delete cascade,
	foreign key (profile_id) references profiles (id) on delete cascade
);

create table permanent_user_logs (
	id					int				not null	auto_increment,
	permanent_user_id	int				not null,
	witer				int				not null,
	content				text			not null,
	register_time		datetime		not null	default current_timestamp,

	primary key (id),
	foreign key (permanent_user_id) references permanent_users (id) on delete cascade,
	foreign key (witer) references users (id) on delete cascade
);

create table users_access (
	user_id				int				not null,
	entity_name			varchar(24)		not null,

	primary key (user_id, entity_name),
	foreign key (user_id) references users (id)
);

create table accounts (
	id					int				not null	auto_increment,
	username			varchar(50)		not null,
	password			varchar(50)		not null,
	permanent_user_id	int					null,

	primary key (id),
	unique (permanent_user_id),
	foreign key (permanent_user_id) references permanent_users (id) on delete cascade
);
