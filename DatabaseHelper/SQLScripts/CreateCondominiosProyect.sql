Create database CondominiosProyect
use CondominiosProyect

Create table Roles(
	id_Rol Int Identity(1,1) NOT NULL,
	descrip Varchar(20) NOT NULL,
	Constraint pk_Roles Primary key(id_Rol)
	);

Create table Personas(
	id_Person Int Identity(1,1) NOT NULL,
	id_Rol Int NOT NULL,
	ced Varchar(15) Unique NOT NULL,
	nombre1 Varchar(30) NOT NULL,
	nombre2 Varchar(30) NULL,
	apellido1 Varchar(30) NOT NULL,
	apellido2 Varchar(30) NOT NULL,
	telef Varchar(15) NOT NULL,
	correo Varchar(50) NOT NULL,
	usuario Varchar(40) NOT NULL,
	contra Varchar(40) NOT NULL,
	Constraint pk_Personas Primary key(id_Person),
	Constraint fk_Personas Foreign key(id_Rol) references Roles(id_Rol)
);

Create table Identificacion(	
	id_Iden Int Identity(1,1) NOT NULL,
	descrip Varchar(30)
	Constraint pk_Identificacion Primary key(id_Iden)
);



Create table Empresas(
	id_Empre Int Identity(1,1) NOT NULL,
	nombre Varchar(50) NOT NULL,
	direc Varchar(100) NOT NULL,
	tel Varchar(15) NOT NULL,
	correo Varchar(50) NOT NULL,
	logo Varchar(100) NOT NULL,
	Constraint pk_Empresas Primary key(id_Empre),


);

Create table AdminPorEmpresas(
	id_Person Int NOT NULL,
	id_Empre Int NOT NULL,
	Constraint pk_AdminPorEmpresas Primary key(id_Person,id_Empre),
	Constraint fk_AdminPorEmpresas Foreign key(id_Person) references Personas(id_Person),
	Constraint fk_AdminPorEmpresas2 Foreign key(id_Empre) references Empresas(id_Empre)
);


Create table Condominios(
	id_Con Int Identity(1,1) NOT NULL,
	id_Empre  NOT NULL,
	nombre Varchar(30) NOT NULL,
	direccion Varchar(100) NOT NULL,
	tel Varchar(15) NOT NULL,
	logo Varchar(100) NOT NULL,
	Constraint pk_Condominios Primary key(id_Con),
	Constraint fk_Condominios Foreign key(id_Empre) references Roles(id_Empre)
);

Create table CasasPorCondominios(
	id_Cas Int Identity(1,1) NOT NULL,
	id_Con Int NOT NULL,
	habitac Int NOT NULL,
	parqueos Int NOT NULL,
	valor Decimal NOT NULL,
	Constraint pk_CasasPorCondominios Primary key(id_Cas),
	Constraint fk_CasasPorCondominios Foreign key(id_Con) references Condominios(id_Con)
);

Create table CasasPorCondominos(
	id_Con Int NOT NULL,
	id_Person Int NOT NULL,
	id_Cas Int NOT NULL,
	Constraint pk_CasasPorCondominos Primary key(id_Con,id_Person,id_Cas),
	Constraint fk_CasasPorCondominos1 Foreign key(id_Con) references Condominios(id_Con),
	Constraint fk_CasasPorCondominos2 Foreign key(id_Person) references Personas(id_Person),
	Constraint fk_CasasPorCondominos3 Foreign key(id_Cas) references CasasPorCondominios(id_Cas)

);

Create table Vehiculos(
	id_Veh Int Identity(1,1) NOT NULL,
	marca Varchar(20) NOT NULL,
	Constraint pk_Vehiculos Primary key(id_Veh)
);

Create table Modelos(
	id_Mol Int Identity(1,1) NOT NULL,
	id_Veh int NOT NULL, 
	modelo Varchar(20) NOT NULL,
	Constraint pk_Modelos Primary key(id_Mol),
	Constraint fk_Modelos Foreign key(id_Veh) references Vehiculos(id_Veh)
);


Create table VehiculosPorCondominos(
	id_Person Int NOT NULL,
	id_Veh int NOT NULL,
	id_Mol Int NOT NULL,
	placa Varchar(15) NOT NULL,
	col_Vehic Varchar(20) NOT NULL,
	Constraint pk_VehiculosPorCondominos Primary key(id_Person,id_Veh,id_Mol),
	Constraint fk_VehiculosPorCondominos1 Foreign key(id_Veh) references Vehiculos(id_Veh),
	Constraint fk_VehiculosPorCondominos2 Foreign key(id_Person) references Personas(id_Person),
	Constraint fk_VehiculosPorCondominos3 Foreign key(id_Mol) references Modelos(id_Mol)

);

Create table VisitasPorCondominios(
	id_Vis Int Identity(1,1) NOT NULL,
	id_Cas Int NOT NULL,
	nombre1 Varchar(30) NOT NULL,
	nombre2 Varchar(30) NULL,
	apellido1 Varchar(30)  NULL,
	apellido2 Varchar(30)  NULL,
	id_Mol Int  NULL,
	id_Veh int  NULL, 
	placa Varchar(15) NOT NULL,
	col_Vehic Varchar(20) NOT NULL,
	id_Vis Int NOT NULL,
	cita datetime NOT NULL,
	ruta_QR Varchar(100) NULL,
	cod_QR Int NULL,
	Constraint pk_VisitasPorCondiminios Primary key(id_Vis),
	Constraint fk_VisitasPorCondiminios1 Foreign key(id_Veh) references Vehiculos(id_Veh),
	Constraint fk_VisitasPorCondiminios2 Foreign key(id_Cas) references CasasPorCondominios(id_Cas),
	Constraint fk_VisitasPorCondiminios3 Foreign key(id_Mol) references Modelos(id_Mol),
	Constraint fk_VisitasPorCondiminios4 Foreign key(id_Vis) references Modelos(id_Vis)

);

Create table TiposVisita(
	id_Vis Int Identity(1,1) NOT NULL,
	descrip Varchar(20) NOT NULL,
	Constraint pk_TiposVisita Primary key(id_Vis)
	);


Create table ActividadGuardas(
	id_Activ Int Identity(1,1) NOT NULL,
	id_Person Int NOT NULL,
	id_Con Int NOT NULL,
	fecha datetime NOT NULL,
	Constraint pk_VisitasPorCondiminios Primary key(id_Activ),
	Constraint fk_ActividadGuardas1 Foreign key(id_Person) references Personas(id_Person),
	Constraint fk_ActividadGuardas2 Foreign key(id_Con) references Condominios(id_Con),
);