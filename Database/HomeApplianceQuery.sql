create table Customer
(
	CustomerID varchar(50) not null,
	CustomerName varchar(50),
	CustomerUsername varchar(50),
	CustomerPassword varchar(16),
	CustomerPhone varchar (30),
	CustomerEmail varchar (50),
	CustomerAddress varchar (100),
	Primary Key (CustomerID)
);
create table Admin_List
(
	AdminID varchar (50) not null,
	AdminName varchar (50),
	AdminUsername varchar (50),
	AdminPassword varchar (16),
	AdmninPhone varchar (30),
	AdminEmail varchar (50),
	AdminAddress varchar (100),
	Salary varchar (20),
	DateofBirth date,
	Primary Key (AdminID)
);
create table Rent
(
	RentID varchar (50) not null,
	CustomerID varchar (50),
	AdminID varchar (50),
	RentDate varchar (30),
	RentalPeriod int ,
	TotalQty int,
	TotalPrice int,
	Promotion int,
	NetPrice int,
	RentalStatus varchar (30),
	Primary Key (RentID),
	Foreign Key (CustomerID) references Customer (CustomerID),
	Foreign Key (AdminID) references Admin_List (AdminID)
);

drop table Customer
drop table Admin_List
drop table Rent

create table ApplianceType
(
	TypeID varchar(50) not null,
	TypeName varchar (100),
	AvaiableQuantity varchar (100),
	TotalQuantity varchar (100),
	InuseQuantity varchar (100),
	Primary Key (TypeID)
);
drop table ApplianceType
create table Appliance
(
	ApplianceID varchar (100) not null,
	ApplianceName varchar (100),
	TypeID varchar (50),
	Brand varchar (50),
	Specs varchar (200),
	Consumption varchar (100),
	MonthlyCost varchar (50),
	MaintainStatus varchar (100)
	Primary Key (ApplianceID),
	Foreign Key (TypeID) references ApplianceType (TypeID)
);
drop table Appliance

create table Inventory
(
	InventoryNumber varchar (20) not null,
	TypeID varchar (50),
	InventoryAddress varchar (100),
	Primary Key (InventoryNumber),
	Foreign Key (TypeID) references ApplianceType (TypeID)
);
drop table Inventory
create table Maintenance
(
	MaintenanceID varchar (100) not null,
	ApplianceID varchar (100),
	MtnStartDate date,
	MtnEndDate date,
	MtnStatus varchar (200),
	Primary Key (MaintenanceID),
	Foreign Key (ApplianceID) references Appliance (ApplianceID)
);
drop table Maintenance
select * from Admin_List
select * from Customer

delete from Customer where CustomerID = 'C0010';
delete from Admin_List
delete from Customer
select * from ApplianceType
delete from ApplianceType
select * from Appliance
delete from Appliance where ApplianceID = 'A0010';


create View ViewApp
AS
(
	select a.ApplianceID, a.ApplianceName, att.TypeName, a.Brand, a.Consumption, a.MonthlyCost, att.AvaiableQuantity
	from Appliance a, ApplianceType att
	where a.TypeID = att.TypeID
)

drop View ViewApp
select * from ViewApp
create table temptbl
(
	ApplianceID varchar (100),
	ApplianceName varchar (100),
	TypeID varchar(50),
	Brand varchar (50),
	Consumption varchar (100),
	MonthlyCost varchar (50),
	AvaiableQuantity varchar (100),
	RentQty int,
	RentAmt int
);

create table ApplianceRent
(
		RentID varchar (50),
		ApplianceID varchar (100),
		RentQty int,
		RentAmt int,
		Foreign Key (ApplianceID) references Appliance (ApplianceID),
		Foreign Key (RentID) references Rent (RentID)

);
select * from temptbl
delete from temptbl
drop table temptbl

select * from Rent
select * from ApplianceRent

Update Appliance
set MaintainStatus = 'Good'
where TypeID = 'AT001'
