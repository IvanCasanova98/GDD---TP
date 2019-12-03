USE GD2C2019;
---------------------------------------------------------------------------------------------------------
------------------------------------------ CREACION DE ESQUEMA ------------------------------------------
---------------------------------------------------------------------------------------------------------
IF NOT EXISTS (select * from sys.schemas where name = 'HPBC')
BEGIN
EXEC('create schema HPBC')
END;
GO

---------------------------------------------------------------------------------------------------------
------------------------------------------ CREACION FUNCION HASH ----------------------------------------
---------------------------------------------------------------------------------------------------------
create FUNCTION HPBC.Hash_Contraseña(@AEncriptar nvarchar(255))
RETURNS varbinary(8000)
BEGIN

RETURN HASHBYTES('SHA2_256', @AEncriptar); 

END
GO

---------------------------------------------------------------------------------------------------------
------------------------------------------ CREACION FUNCION Base36 --------------------------------------
---------------------------------------------------------------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='fnBase36' AND type='F')
DROP FUNCTION HPBC.fnBase36
GO
CREATE FUNCTION HPBC.fnBase36
(
    @Val BIGINT
)
RETURNS VARCHAR(9)
AS
BEGIN
    DECLARE @Result VARCHAR(9) = ''

    IF (@Val <= 0)
    BEGIN
        RETURN '0'
    END

    WHILE (@Val > 0)
    BEGIN
        SELECT @Result = CHAR(@Val % 36 + CASE WHEN @Val % 36 < 10 THEN 48 ELSE 55 END) + @Result,
               @Val = FLOOR(@Val/36)
    END

    RETURN @Result
END
GO

--------------------------------------------------------------------------------------------------------
------------------------------------------ CREACION DE TABLAS ------------------------------------------
--------------------------------------------------------------------------------------------------------
IF NOT EXISTS (select * from sysobjects where name='Cliente' and xtype='U')
CREATE TABLE HPBC.Cliente(
	clie_ID INT NOT NULL IDENTITY(1,1),
	clie_nombre nvarchar(255) NOT NULL,
	clie_apellido nvarchar(255) NOT NULL,
	clie_dni numeric(18,0)  NOT NULL,
	clie_mail nvarchar(255)  NOT NULL,
	clie_tel numeric(18,0)  NULL,
	clie_fecha_nac datetime NOT NULL,
	clie_calle varchar(255),
	clie_piso numeric(2,0),
	clie_dpto varchar(2),
	clie_localidad nvarchar(255) NULL,
	clie_habilitado bit NOT NULL,
	clie_monto numeric(18,0) NOT NULL,
	clie_usuario_ID INT,
 CONSTRAINT PK_Cliente PRIMARY KEY CLUSTERED(
	clie_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO


IF NOT EXISTS (select * from sysobjects where name='Usuario' and xtype='U')
CREATE TABLE HPBC.Usuario(
	usuario_id INT NOT NULL IDENTITY(1,1),
	usuario_username nvarchar(50) NOT NULL,
	usuario_password varbinary(8000) NOT NULL,
	usuario_habilitado BIT NOT NULL,
	usuario_bloqueado BIT NOT NULL,
	usuario_cant_logeo_error INT NULL,
 CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED(
	usuario_id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO


IF NOT EXISTS (select * from sysobjects where name='Proveedor' and xtype='U')
CREATE TABLE HPBC.Proveedor(
	Provee_ID INT NOT NULL identity(1,1) ,
	Provee_Rs nvarchar(100)  NOT NULL,
	Provee_Calle nvarchar(255),
	Provee_Piso numeric(2,0),
	Provee_Dpto varchar(2),
	Provee_Localidad varchar(255),
	Provee_Ciudad varchar(255),
	Provee_CodPostal numeric(4,0),
	Provee_Mail nvarchar(255) ,
	Provee_CUIT nvarchar(20)  NOT NULL,
	Provee_Tel numeric(14,0) ,
	Provee_NombreContacto varchar(100),
	Provee_Habilitado Bit NOT NULL,
	Provee_Rubro INT,
	Provee_usuario_id INT,
 CONSTRAINT PK_Proveedor PRIMARY KEY CLUSTERED(
	Provee_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Rol' and xtype='U')
CREATE TABLE HPBC.Rol(
	Rol_ID INT identity(1,1) NOT NULL,
	Rol_detalle nvarchar(255) NOT NULL,
	Rol_Habilitado Bit DEFAULT 1,
 CONSTRAINT PK_Rol PRIMARY KEY CLUSTERED(
	Rol_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Funcion' and xtype='U')
CREATE TABLE HPBC.Funcion(
	Func_ID INT identity(1,1) NOT NULL,
	Func_detalle nvarchar(255) NOT NULL,
 CONSTRAINT PK_Funcion PRIMARY KEY CLUSTERED(
	Func_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Rol_Por_Usuario' and xtype='U')
CREATE TABLE HPBC.Rol_Por_Usuario(
	ID_Rol INT NOT NULL,
	ID_Usuario INT NOT NULL,
 CONSTRAINT PK_Rol_Por_Usuario PRIMARY KEY CLUSTERED(
	ID_Rol ASC,
	ID_Usuario ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Funcion_Por_Rol' and xtype='U')
CREATE TABLE HPBC.Funcion_Por_Rol(
	Rol_ID INT NOT NULL,
	Func_ID INT NOT NULL,
 CONSTRAINT PK_Funcion_Por_Rol PRIMARY KEY CLUSTERED(
	Rol_ID ASC,
	Func_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Credito' and xtype='U')
CREATE TABLE HPBC.Credito(
	Credito_ID INT identity(1,1) NOT NULL,
	Credito_ID_Clie INT NOT NULL,
	Carga_Fecha datetime,
	Carga_Monto numeric(18,2),
	Credito_ID_Tarjeta INT NOT NULL,
 CONSTRAINT PK_Creditos PRIMARY KEY CLUSTERED(
	Credito_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Tipo_Pago' and xtype='U')
CREATE TABLE HPBC.Tipo_Pago(
	Tipo_Pago_ID INT NOT NULL identity(1,1) ,
	Tarj_Detalle nvarchar(100) NOT NULL,
	Tarj_Nro numeric(20,0) null,
	Tarj_Cod_Seg numeric(4,0) null,
 CONSTRAINT PK_Tipo_Pago PRIMARY KEY CLUSTERED(
	Tipo_Pago_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Factura' and xtype='U')
CREATE TABLE HPBC.Factura(
	Fact_ID INT identity(1,1) NOT NULL,
	Fact_ID_Proveedor INT NOT NULL,
	Fact_Fecha datetime,
	Fact_Nro numeric (18,0),
	Fact_Monto int
 CONSTRAINT PK_Fact PRIMARY KEY CLUSTERED(
	Fact_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Oferta' and xtype='U')
CREATE TABLE HPBC.Oferta(
	Ofe_ID INT identity(1,1) NOT NULL,
	Ofe_ID_Proveedor INT NOT NULL,
	Ofe_Precio numeric(18,2) NOT NULL,
	Ofe_Precio_Ficticio numeric(18,2),
	Ofe_Fecha datetime,
	Ofe_Fecha_Venc datetime,
	Ofe_Descrip nvarchar(255),
	Ofe_Cant numeric(18,0),
	Ofe_Max_Cant_Por_Usuario numeric(18,0) null,
	Ofe_Codigo nvarchar(50),
	Ofe_Accesible BIT DEFAULT 1
 CONSTRAINT PK_Oferta PRIMARY KEY CLUSTERED(
	Ofe_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Compra' and xtype='U')
CREATE TABLE HPBC.Compra(
	Compra_ID int identity(1,1) NOT NULL,
	Compra_ID_Oferta int  NOT NULL,
	Compra_ID_Clie_Dest Int  NOT NULL,
	Compra_Fecha datetime,
	Compra_Cant numeric(18,0),
	Compra_Facturada BIT DEFAULT 0
 CONSTRAINT PK_Compra PRIMARY KEY CLUSTERED(
	Compra_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Cupon' and xtype='U')
CREATE TABLE HPBC.Cupon(
	Cupon_ID Int identity(1,1) NOT NULL,
	Cupon_ID_Compra Int NOT NULL,
	Cup_Fecha_Consumo datetime,
	Cup_Fecha_Venc datetime,
	Cup_Codigo varchar(255),
 CONSTRAINT PK_Cupon PRIMARY KEY CLUSTERED(
	Cupon_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Detalle_Fact' and xtype='U')
CREATE TABLE HPBC.Detalle_Fact(
	Detalle_Fact_ID int identity(1,1) NOT NULL,
	Detalle_ID_Fact Int NOT NULL,
	Detalle_ID_Compra int NOT NULL,
 CONSTRAINT PK_Detalle_Fact PRIMARY KEY CLUSTERED(
	Detalle_Fact_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

IF NOT EXISTS (select * from sysobjects where name='Rubro' and xtype='U')
CREATE TABLE HPBC.Rubro(
	Rubro_ID int identity(1,1) NOT NULL,
	Rubro_detalle nvarchar(255) NOT NULL,
 CONSTRAINT PK_Rubro PRIMARY KEY CLUSTERED(
	Rubro_ID ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)ON [PRIMARY]
GO

-------------------------------------------------------------------------------------------------------------------
------------------------------------------ Creacion de las FOREIGN KEYSS ------------------------------------------
-------------------------------------------------------------------------------------------------------------------
IF NOT EXISTS (select * from sysobjects where name='FK_Cliente_ID_Usuario' and xtype='F')
ALTER TABLE HPBC.Cliente WITH CHECK ADD CONSTRAINT FK_Cliente_ID_Usuario  FOREIGN KEY(clie_usuario_ID)
REFERENCES HPBC.Usuario(usuario_id)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Provedor_ID_Usuario' and xtype='F')
ALTER TABLE HPBC.Proveedor WITH CHECK ADD CONSTRAINT FK_Provedor_ID_Usuario FOREIGN KEY(Provee_usuario_id)
REFERENCES HPBC.Usuario(usuario_id)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Usuario_ID_Rol' and xtype='F')
ALTER TABLE HPBC.Rol_Por_Usuario WITH CHECK ADD CONSTRAINT FK_Usuario_ID_Rol FOREIGN KEY(ID_Rol)
REFERENCES HPBC.Rol(Rol_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Rol_ID_Usuario' and xtype='F')
ALTER TABLE HPBC.Rol_Por_Usuario WITH CHECK ADD CONSTRAINT FK_Rol_ID_Usuario FOREIGN KEY(ID_Usuario)
REFERENCES HPBC.Usuario(usuario_id)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Funcion_ID_Rol' and xtype='F')
ALTER TABLE HPBC.Funcion_Por_Rol WITH CHECK ADD CONSTRAINT FK_Funcion_ID_Rol FOREIGN KEY(Rol_ID)
REFERENCES HPBC.Rol(Rol_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Rol_ID_Funcion' and xtype='F')
ALTER TABLE HPBC.Funcion_Por_Rol WITH CHECK ADD CONSTRAINT FK_Rol_ID_Funcion FOREIGN KEY(Func_ID)
REFERENCES HPBC.Funcion(Func_ID)
GO


IF NOT EXISTS (select * from sysobjects where name='FK_Oferta_ID_Provedor' and xtype='F')
ALTER TABLE HPBC.Oferta WITH CHECK ADD CONSTRAINT FK_Oferta_ID_Provedor FOREIGN KEY(Ofe_ID_Proveedor)
REFERENCES HPBC.Proveedor(Provee_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Provee_ID_Rubro' and xtype='F')
ALTER TABLE HPBC.Proveedor WITH CHECK ADD CONSTRAINT FK_Provee_ID_Rubro FOREIGN KEY(Provee_Rubro)
REFERENCES HPBC.Rubro(Rubro_ID)
GO


IF NOT EXISTS (select * from sysobjects where name='FK_Compra_ID_Oferta' and xtype='F')
ALTER TABLE HPBC.Compra WITH CHECK ADD CONSTRAINT FK_Compra_ID_Oferta FOREIGN KEY(Compra_ID_Oferta)
REFERENCES HPBC.Oferta(Ofe_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Compra_ID_Clie' and xtype='F')
ALTER TABLE HPBC.Compra WITH CHECK ADD CONSTRAINT FK_Compra_ID_Clie FOREIGN KEY(Compra_ID_Clie_Dest)
REFERENCES HPBC.Cliente(clie_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Cupon_ID_Compra' and xtype='F')
ALTER TABLE HPBC.Cupon WITH CHECK ADD CONSTRAINT FK_Cupon_ID_Compra FOREIGN KEY (Cupon_ID_Compra)
REFERENCES HPBC.Compra(Compra_ID)
GO


IF NOT EXISTS (select * from sysobjects where name='FK_Credito_ID_Clie' and xtype='F')
ALTER TABLE HPBC.Credito WITH CHECK ADD CONSTRAINT FK_Credito_ID_Clie FOREIGN KEY (Credito_ID_Clie)
REFERENCES HPBC.Cliente(clie_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Credito_ID_Tarjeta' and xtype='F')
ALTER TABLE HPBC.Credito WITH CHECK ADD CONSTRAINT FK_Credito_ID_Tarjeta FOREIGN KEY (Credito_ID_Tarjeta)
REFERENCES HPBC.Tipo_Pago(Tipo_Pago_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Fact_ID_Proveedor' and xtype='F')
ALTER TABLE HPBC.Factura WITH CHECK ADD CONSTRAINT FK_Fact_ID_Proveedor FOREIGN KEY (Fact_ID_Proveedor)
REFERENCES HPBC.Proveedor(Provee_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Detalle_ID_Fact' and xtype='F')
ALTER TABLE HPBC.Detalle_Fact WITH CHECK ADD CONSTRAINT FK_Detalle_ID_Fact FOREIGN KEY (Detalle_ID_Fact)
REFERENCES HPBC.Factura(Fact_ID)
GO

IF NOT EXISTS (select * from sysobjects where name='FK_Detalle_ID_Compra' and xtype='F')
ALTER TABLE HPBC.Detalle_Fact  WITH CHECK ADD CONSTRAINT FK_Detalle_ID_Compra FOREIGN KEY (Detalle_ID_Compra)
REFERENCES HPBC.Compra(Compra_ID)
GO

--IF NOT EXISTS (select * from sysobjects where name='FK_Compra_Factura' and xtype='F')
--ALTER TABLE HPBC.Compra  WITH CHECK ADD CONSTRAINT FK_Compra_Factura FOREIGN KEY (Compra_ID_Factura)
--REFERENCES HPBC.Factura(Fact_ID)
-----GO


USE [master]
GO
ALTER DATABASE [GD2C2019] SET READ_WRITE 
GO
USE GD2C2019;
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='limpiar_tablas' AND type='p')
DROP PROCEDURE HPBC.limpiar_tablas
GO
CREATE PROCEDURE HPBC.limpiar_tablas
AS
BEGIN
DELETE FROM [HPBC].[Cliente]
DELETE FROM [HPBC].[Compra]
DELETE FROM [HPBC].[Credito]
DELETE FROM [HPBC].[Cupon]
DELETE FROM [HPBC].[Detalle_Fact]
DELETE FROM [HPBC].[Factura]
DELETE FROM [HPBC].[Funcion]
DELETE FROM [HPBC].[Funcion_Por_Rol]
DELETE FROM [HPBC].[Oferta]
DELETE FROM [HPBC].[Proveedor]
DELETE FROM [HPBC].[Rol]
DELETE FROM [HPBC].[Rol_Por_Usuario]
DELETE FROM [HPBC].[Rubro]
DELETE FROM [HPBC].[Tipo_Pago]
DELETE FROM [HPBC].[Usuario]
END
GO

EXEC HPBC.limpiar_tablas
GO

-------------------------------------------------------------------------------------------------------------------
------------------------------------------ Inserto valores predeterminados ----------------------------------------
-------------------------------------------------------------------------------------------------------------------
INSERT INTO HPBC.Funcion(Func_detalle)
Values('ABM DE ROL')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('REGISTRO')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('ABM DE CLIENTE')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('ABM DE PROVEEDOR')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('CARGAR CREDITO')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('CONFECCIÓN Y PUBLICACIÓN DE OFERTAS')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('COMPRAR OFERTA')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('ENTREGA/CONSUMO DE OFERTA')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('FACTURACIÓN A PROVEEDOR')
INSERT INTO HPBC.Funcion(Func_detalle)
Values('LISTADO ESTADÍSTICO')

INSERT INTO HPBC.Rol(Rol_detalle)
Values('Administrador General')
INSERT INTO HPBC.Rol(Rol_detalle)
Values('Cliente')
INSERT INTO HPBC.Rol(Rol_detalle)
Values('Proveedor')

/*le doy a los roles sus funcs*/
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,1)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,3)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,4)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,6)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,9)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,10)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,5)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,7)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(1,8)



INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(2,2)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(2,5)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(2,7)

INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(3,2)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(3,6)
INSERT INTO HPBC.Funcion_Por_Rol(Rol_ID,Func_ID)
Values(3,8)

--admin
INSERT INTO HPBC.Usuario(usuario_username, usuario_password, usuario_habilitado, usuario_bloqueado, usuario_cant_logeo_error)
VALUES('admin',HASHBYTES('SHA2_256','w23e'),1,0,0)
GO
INSERT INTO HPBC.Rol_Por_Usuario(ID_Rol ,ID_Usuario)
SELECT 1, (SELECT usuario_id from  HPBC.Usuario WHERE usuario_username= 'admin')
GO

--Creo triggers para bajas logicas

IF EXISTS (SELECT name FROM sysobjects WHERE name='trigger_baja_logica' AND type='tr')
DROP TRIGGER HPBC.trigger_baja_logica
GO
create TRIGGER HPBC.trigger_baja_logica ON HPBC.Rol FOR UPDATE
AS 
BEGIN TRANSACTION
	IF EXISTS(SELECT 1 FROM inserted i WHERE i.Rol_Habilitado = 0)
	BEGIN
		DELETE FROM HPBC.Rol_Por_Usuario
		WHERE ID_Rol = (SELECT i.Rol_ID FROM inserted i)
	END
COMMIT TRANSACTION
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='trigger_finalizar_oferta' AND type='tr')
DROP TRIGGER HPBC.trigger_finalizar_oferta
GO
CREATE TRIGGER HPBC.trigger_finalizar_oferta
ON HPBC.Oferta
AFTER UPDATE AS
BEGIN
	IF EXISTS(SELECT 1 FROM HPBC.Oferta i WHERE i.Ofe_Cant <= 0 and i.Ofe_Accesible = 1)
	BEGIN
		UPDATE HPBC.Oferta
		SET Ofe_Accesible = 0, Ofe_Cant = 0
		WHERE Ofe_Cant <=0;
	END
END
GO


/*IF EXISTS (SELECT name FROM sysobjects WHERE name='trigger_facturar_compra' AND type='tr')
DROP TRIGGER HPBC.trigger_facturar_compra
GO
CREATE TRIGGER HPBC.trigger_facturar_compra
ON HPBC.Detalle_Fact
AFTER Insert AS
BEGIN
		UPDATE HPBC.Compra
		SET Compra_Facturada = 1
		WHERE Compra_ID IN (SELECT i.Detalle_ID_Compra from inserted i where Compra_ID = i.Detalle_ID_Compra)
	END
GO*/
-------------------------------------------------------------------------------------------------------------------
------------------------------------------ MIGRACION --------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_limpiar_tabla_maestra_clientes' AND type='p')
DROP PROCEDURE HPBC.pr_limpiar_tabla_maestra_clientes
GO
CREATE PROCEDURE HPBC.pr_limpiar_tabla_maestra_clientes
	AS
	BEGIN
	SELECT Cli_Nombre AS Nombre,Cli_Apellido AS Apellido,convert(nvarchar(255),Cli_Dni) AS Dni ,Cli_Direccion, Cli_Telefono AS Telefono, Cli_Mail as Email,Cli_Ciudad, Cli_Fecha_Nac
	INTO #Temp_Clientes
	FROM GD2C2019.gd_esquema.Maestra
	WHERE Cli_Dni IS NOT NULL AND Cli_Mail IS NOT NULL
	GROUP BY Cli_Nombre,Cli_Apellido,Cli_Dni,Cli_Fecha_Nac,Cli_Mail,Cli_Direccion,Cli_Telefono,Cli_Ciudad;
	
	/*Se busca si existe incosistencia en los datos mediante otra tabla Temporal*/
	SELECT  Nombre,Apellido,Dni,Cli_Fecha_Nac,Email,Cli_Direccion,Telefono,Cli_Ciudad,row_number() OVER(PARTITION BY Dni ORDER BY Email) AS cantDni,row_number() OVER(PARTITION BY Email ORDER BY Email) AS cantEmail
	INTO #Temp_Cli_Incons
	FROM #Temp_Clientes
	GROUP BY Nombre,Apellido,Dni,Cli_Fecha_Nac,Email,Cli_Direccion,Telefono,Cli_Ciudad;
	
	/* Borro la primer tabla temporal, ya que no sirve mas */
	DROP TABLE #Temp_Clientes;
	
	/* Se cren los usuarios de los Clientes */
	INSERT INTO HPBC.Usuario (usuario_username, usuario_password, usuario_habilitado, usuario_bloqueado, usuario_cant_logeo_error)
	SELECT Dni AS username , HASHBYTES('SHA2_256',convert(varchar(255),Dni)), 1, 0, 0
	FROM #Temp_Cli_Incons
	WHERE cantDni = 1 AND cantEmail = 1 
	
	/* Se les asigna el Rol de Cliente */
	INSERT INTO HPBC.Rol_Por_Usuario(ID_Rol ,ID_Usuario)
	SELECT 2, usuario_id 
	FROM HPBC.Usuario
	WHERE usuario_id NOT IN (SELECT ID_Usuario FROM HPBC.Rol_Por_Usuario)
	
	/* Inserto clientes*/
	INSERT INTO HPBC.Cliente (clie_nombre, clie_apellido,  clie_dni, clie_mail, clie_tel, clie_calle, clie_fecha_nac, clie_localidad, clie_habilitado,clie_monto, clie_usuario_id)
	SELECT Nombre, Apellido, convert(numeric(18,0),Dni),  REPLACE(Email,' ',''), Telefono, Cli_Direccion,Cli_Fecha_Nac,Cli_Ciudad, 1,200 ,u.usuario_id
	FROM #Temp_Cli_Incons 
	INNER JOIN HPBC.Usuario u
	ON Dni = u.usuario_username
	WHERE cantDni = 1 and cantEmail = 1 
	ORDER BY dni
	
	
	DROP TABLE #Temp_Cli_Incons;
	END
	GO


EXEC HPBC.pr_limpiar_tabla_maestra_clientes
GO

-------------------------------------------------------------------------------------------------------------------
------------------------------------------ trigger para updatear las cargas de los clientes -----------------------
-------------------------------------------------------------------------------------------------------------------
IF EXISTS (SELECT name FROM sysobjects WHERE name='updatear_monto_por_carga' AND type='tr')
DROP TRIGGER HPBC.updatear_monto_por_carga
GO
CREATE TRIGGER HPBC.updatear_monto_por_carga ON HPBC.Credito for insert
AS
BEGIN TRANSACTION
	UPDATE Cliente set clie_monto = clie_monto + (SELECT sum(Carga_Monto) from inserted where Credito_ID_Clie = clie_ID)
	WHERE EXISTS(SELECT 1 FROM inserted WHERE Credito_ID_Clie = clie_ID)
	
COMMIT TRANSACTION
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_tarjetas' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_tarjetas
GO
CREATE PROCEDURE HPBC.pr_cargar_tarjetas 
AS
BEGIN
INSERT INTO HPBC.Tipo_Pago(Tarj_Detalle,Tarj_Nro,Tarj_Cod_Seg)
SELECT DISTINCT Tipo_Pago_Desc, null,null from gd_esquema.Maestra
WHERE Tipo_Pago_Desc is NOT NULL
Group by Tipo_Pago_Desc
END
GO

EXEC HPBC.pr_cargar_tarjetas
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_creditos' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_creditos
GO
CREATE PROCEDURE HPBC.pr_cargar_creditos
AS
BEGIN
INSERT INTO HPBC.Credito(Credito_ID_Clie,Carga_Fecha,Carga_Monto,Credito_ID_Tarjeta)
SELECT clie_ID , gd.Carga_Fecha, gd.Carga_Credito, (SELECT Tipo_Pago_ID from HPBC.Tipo_Pago where gd.Tipo_Pago_Desc=Tarj_Detalle)
from gd_esquema.Maestra gd  join HPBC.Cliente ON clie_dni = gd.Cli_Dni and clie_mail = gd.Cli_Mail
WHERE  gd.Carga_Fecha IS NOT NULL AND gd.Carga_Credito IS NOT NULL and gd.Cli_Dni IS NOT NULL AND gd.Tipo_Pago_Desc IS NOT NULL
END
GO

EXEC HPBC.pr_cargar_creditos
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_rubros' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_rubros
GO
CREATE PROCEDURE HPBC.pr_cargar_rubros
AS
BEGIN
INSERT INTO HPBC.Rubro(Rubro_detalle)
SELECT DISTINCT Provee_Rubro from gd_esquema.Maestra
where Provee_Rubro is not null
END
GO

EXEC HPBC.pr_cargar_rubros
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_provedores' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_provedores
GO
CREATE PROCEDURE HPBC.pr_cargar_provedores
AS
BEGIN
	SELECT Provee_RS AS RS,Provee_Dom AS Domicilio,Provee_Telefono AS Telefono, REPLACE(Provee_CUIT,'-','') AS CUIT ,Provee_Rubro, Provee_Ciudad as Ciudad
	INTO #Temp_Provee
	FROM GD2C2019.gd_esquema.Maestra
	WHERE Provee_RS IS NOT NULL AND Provee_CUIT IS NOT NULL
	GROUP BY Provee_RS,Provee_Dom,Provee_Telefono,Provee_CUIT,Provee_Rubro,Provee_Ciudad
	
	SELECT  RS,Domicilio,Telefono,CUIT,Provee_Rubro,Ciudad,row_number() OVER(PARTITION BY RS ORDER BY CUIT) AS cantRS,row_number() OVER(PARTITION BY CUIT ORDER BY CUIT) AS cantCUIT
	INTO #Temp_Provee_Incons
	FROM #Temp_Provee
	GROUP BY RS,Domicilio,Telefono,CUIT,Provee_Rubro,Ciudad

	DROP TABLE #Temp_Provee;
	
	/* Se cren los usuarios de los Clientes */
	INSERT INTO HPBC.Usuario (usuario_username, usuario_password, usuario_habilitado, usuario_bloqueado, usuario_cant_logeo_error)
	SELECT CUIT AS username , HASHBYTES('SHA2_256',convert(varchar(255),CUIT)), 1, 0, 0
	FROM #Temp_Provee_Incons
	WHERE cantRS = 1 AND cantCUIT = 1

	INSERT INTO HPBC.Rol_Por_Usuario(ID_Rol ,ID_Usuario)
	SELECT 3, usuario_id 
	FROM HPBC.Usuario
	WHERE usuario_id NOT IN (SELECT ID_Usuario FROM HPBC.Rol_Por_Usuario)


	INSERT INTO HPBC.Proveedor(Provee_Rs, Provee_Calle, Provee_Piso,Provee_Dpto,Provee_Localidad,Provee_Ciudad,Provee_CodPostal,Provee_Mail,Provee_CUIT,Provee_Tel,Provee_NombreContacto,Provee_Habilitado,Provee_Rubro,Provee_usuario_id)
	SELECT RS, Domicilio,null,null,null,Ciudad,null,null, CUIT,  Telefono, null, 1,(SELECT Rubro_ID from HPBC.Rubro where Rubro_detalle = Provee_Rubro) ,u.usuario_id
	FROM #Temp_Provee_Incons 
	INNER JOIN HPBC.Usuario u
	ON CUIT = u.usuario_username
	WHERE cantCUIT = 1 and cantRS = 1 
	ORDER BY CUIT
	END
	GO

exec HPBC.pr_cargar_provedores


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_carga_facturas' AND type='p')
DROP PROCEDURE HPBC.pr_carga_facturas
GO
CREATE PROCEDURE HPBC.pr_carga_facturas
AS
BEGIN
	INSERT INTO HPBC.Factura(Fact_Nro,Fact_ID_Proveedor,Fact_Fecha,Fact_Monto)
	SELECT Distinct gd.Factura_Nro, p.Provee_ID , gd.Factura_Fecha, SUM(gd.Oferta_Precio)
	from gd_esquema.Maestra gd join HPBC.Proveedor p on p.Provee_Rs = gd.Provee_RS and REPLACE(gd.Provee_CUIT,'-','') = p.Provee_CUIT
	where Factura_Nro is not null and Factura_Fecha is not null
	group by gd.Factura_Nro, p.Provee_ID , gd.Factura_Fecha
	order by Factura_Nro
END
GO
exec HPBC.pr_carga_facturas


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_ofertas' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_ofertas
GO
CREATE PROCEDURE HPBC.pr_cargar_ofertas
AS
BEGIN
	insert into HPBC.Oferta(Ofe_Codigo, Ofe_Descrip, Ofe_Precio_Ficticio,Ofe_Fecha,Ofe_Fecha_Venc,Ofe_Cant,Ofe_Precio,Ofe_Max_Cant_Por_Usuario,Ofe_Accesible,Ofe_ID_Proveedor)
	SELECT DISTINCT Oferta_Codigo, Oferta_Descripcion, Oferta_Precio,Oferta_Fecha, Oferta_Fecha_Venc,  Oferta_Cantidad,Oferta_Precio_Ficticio, Oferta_Cantidad,1, Provee_ID 
	from gd_esquema.Maestra r, HPBC.Proveedor p
	WHERE p.Provee_Rs= r.Provee_RS and p.Provee_CUIT = REPLACE(r.Provee_CUIT , '-' , '') and r.Oferta_Cantidad is not null and r.Oferta_Descripcion is not null and r.Oferta_Precio_Ficticio is not null  and r.Oferta_Fecha is not null and r.Oferta_Fecha_Venc is not null and r.Oferta_Precio is not null
END
GO

exec HPBC.pr_cargar_ofertas


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_compras' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_compras
GO
CREATE PROCEDURE HPBC.pr_cargar_compras
AS
BEGIN
	INSERT INTO HPBC.Compra(Compra_ID_Oferta,Compra_ID_Clie_Dest,Compra_Fecha, Compra_Cant)
	SELECT	o.Ofe_ID,
			c.clie_ID, 
			gd.Oferta_Fecha_Compra, 
			1
	from gd_esquema.Maestra gd, HPBC.Cliente c,HPBC.Oferta o
	where gd.Oferta_Fecha_Compra is not null and c.clie_apellido = gd.Cli_Apellido AND c.clie_nombre = gd.Cli_Nombre AND c.clie_dni = gd.Cli_Dni 
	and o.Ofe_Codigo = gd.Oferta_Codigo
	and gd.Oferta_Entregado_Fecha is null and gd.Factura_Fecha is null and gd.Factura_Nro is null 
END
GO


exec HPBC.pr_cargar_compras


UPDATE o SET o.Ofe_Cant =  o.Ofe_Cant - (select isnull(COUNT(*),0)  FROM HPBC.Compra c WHERE c.Compra_ID_Oferta = o.Ofe_ID  group by c.Compra_ID_Oferta)
FROM HPBC.Oferta o
Where (select isnull(COUNT(*),0)  FROM HPBC.Compra c WHERE c.Compra_ID_Oferta = o.Ofe_ID  group by c.Compra_ID_Oferta) != 0 --por alguna razon si da 0 el campo queda en null


--Creo un cupon por CADA compra algunos ya estan entregados otros no;

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_cupones' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_cupones
GO
CREATE PROCEDURE HPBC.pr_cargar_cupones
AS
BEGIN
	INSERT INTO HPBC.Cupon(Cupon_ID_Compra,Cup_Codigo,Cup_Fecha_Consumo,Cup_Fecha_Venc)
	SELECT Compra_ID, Ofe_Codigo + HPBC.fnBase36(Compra_ID),gd.Oferta_Entregado_Fecha, DATEADD(MM, 1, gd.Oferta_Fecha_Compra)
	FROM HPBC.Compra INNER join HPBC.Oferta ON Compra_ID_Oferta = Ofe_ID 
	, gd_esquema.Maestra gd
	where (Factura_Fecha is null and Factura_Nro is null and Oferta_Codigo = Ofe_Codigo) and ((Oferta_Entregado_Fecha is not null)or Oferta_Entregado_Fecha is null 
	and not exists(SELECT 1 FROM gd_esquema.Maestra gd2 where gd2.Oferta_Codigo = Ofe_Codigo and gd2.Oferta_Entregado_Fecha is not null and Compra_ID_Clie_Dest = (SELECT clie_ID from HPBC.Cliente where clie_dni = Cli_Dni) and  Compra_Fecha = gd2.Oferta_Fecha_Compra)) 
	and Compra_ID_Clie_Dest = (SELECT clie_ID from HPBC.Cliente where clie_dni = Cli_Dni) and Compra_Fecha = gd.Oferta_Fecha_Compra
	group by Compra_ID, Ofe_Codigo + HPBC.fnBase36(Compra_ID),Oferta_Entregado_Fecha, DATEADD(MM, 1,gd.Oferta_Fecha_Compra)
	ORDER BY Compra_ID
END
GO
exec HPBC.pr_cargar_cupones

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_item_factura' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_item_factura
GO
CREATE PROCEDURE HPBC.pr_cargar_item_factura
AS
BEGIN
	INSERT INTO HPBC.Detalle_Fact 
	SELECT Fact_ID,Compra_ID 
	FROM gd_esquema.Maestra, HPBC.Compra,HPBC.Factura
	where Factura_Nro = Fact_Nro and Cli_Dni = (SELECT clie_dni FROM HPBC.Cliente WHERE clie_ID = Compra_ID_Clie_Dest)  and Oferta_Codigo = (SELECT Ofe_Codigo FROM HPBC.Oferta where Ofe_ID = Compra_ID_Oferta) and Oferta_Fecha_Compra = Compra_Fecha
end
GO
exec HPBC.pr_cargar_item_factura

UPDATE c SET Compra_Facturada = 1
FROM HPBC.Compra c
WHERE c.Compra_ID = (SELECT Detalle_ID_Compra from HPBC.Detalle_Fact where Detalle_ID_Compra = c.Compra_ID)

/*IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_cargar_item_factura' AND type='p')
DROP PROCEDURE HPBC.pr_cargar_item_factura 
GO
CREATE PROCEDURE HPBC.pr_cargar_item_factura
AS
BEGIN
	INSERT INTO HPBC.Detalle_Fact(Detalle_ID_Fact,Detalle_ID_Compra)
	SELECT f.Fact_ID,c.Compra_ID from HPBC.Factura f JOIN gd_esquema.Maestra gd on gd.Factura_Nro = f.Fact_Nro 
	join HPBC.Compra c on gd.Cli_Dni = (Select clie_dni from HPBC.Cliente where c.Compra_ID_Clie_Dest = clie_ID)
	where gd.Factura_Nro is not null and gd.Factura_Fecha is not null
END
GO
exec HPBC.pr_cargar_item_factura*/


IF EXISTS (SELECT name FROM sysobjects WHERE name='validar_usuario' AND type='fn')
DROP FUNCTION HPBC.validar_usuario
GO
CREATE FUNCTION HPBC.validar_usuario (@usuario varchar(255), @pass varchar(255))
RETURNS INT
AS
BEGIN
DECLARE @respuestaProtocolo INT
IF EXISTS(SELECT 1 FROM HPBC.Usuario where usuario_username = @usuario and usuario_password = HASHBYTES('SHA2_256',@pass) and usuario_bloqueado=0 and usuario_habilitado=1)
	BEGIN
	SET @respuestaProtocolo = 1
	RETURN @respuestaProtocolo 
	END
IF EXISTS(SELECT 1 FROM HPBC.Usuario where usuario_username = @usuario and usuario_password != HASHBYTES('SHA2_256',@pass) and usuario_bloqueado=0 and usuario_habilitado=1) 
	BEGIN
	SET @respuestaProtocolo = 4
	RETURN @respuestaProtocolo 
	END
IF EXISTS(SELECT 1 FROM HPBC.Usuario where usuario_username = @usuario  and usuario_bloqueado=1)
	BEGIN
	SET @respuestaProtocolo = 3
	RETURN @respuestaProtocolo
	END
IF EXISTS(SELECT 1 FROM HPBC.Usuario where usuario_username = @usuario and usuario_habilitado=0)
	BEGIN
	SET @respuestaProtocolo = 2
	RETURN @respuestaProtocolo
	END
RETURN 0
END
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_aumentar_cant_login_fallido' AND type='p')
DROP PROCEDURE HPBC.pr_aumentar_cant_login_fallido
GO
CREATE PROCEDURE HPBC.pr_aumentar_cant_login_fallido(@username varchar(255))
AS
BEGIN
UPDATE HPBC.Usuario 
SET usuario_cant_logeo_error = usuario_cant_logeo_error + 1
WHERE usuario_id = (SELECT u.usuario_id FROM HPBC.Usuario u WHERE u.usuario_username =  @username )
END
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_resetear_cant_login_fallido' AND type='p')
DROP PROCEDURE HPBC.pr_resetear_cant_login_fallido
GO
CREATE PROCEDURE HPBC.pr_resetear_cant_login_fallido(@username varchar(255))
AS
BEGIN
UPDATE HPBC.Usuario 
SET usuario_cant_logeo_error = 0
WHERE usuario_id = (SELECT u.usuario_id FROM HPBC.Usuario u WHERE u.usuario_username =  @username )
END
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='tr_bloquear_usuario' AND type='tr')
DROP TRIGGER HPBC.tr_bloquear_usuario
GO
CREATE TRIGGER HPBC.tr_bloquear_usuario on HPBC.Usuario after UPDATE
AS
BEGIN TRANSACTION
UPDATE HPBC.Usuario
SET usuario_bloqueado = 1
Where usuario_id in (SELECT u.usuario_id from HPBC.Usuario u Where u.usuario_username = usuario_username and usuario_cant_logeo_error >= 3)
COMMIT TRANSACTION
go

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_borrar_relaciones_de_un_rol_x_funcion' AND type='p')
DROP PROCEDURE HPBC.pr_borrar_relaciones_de_un_rol_x_funcion
GO
CREATE PROCEDURE HPBC.pr_borrar_relaciones_de_un_rol_x_funcion(@rol varchar(255))
AS
BEGIN
Delete from HPBC.Funcion_Por_Rol 
WHERE Func_ID in (select fr.Func_ID from HPBC.Rol r join HPBC.Funcion_Por_Rol fr on r.Rol_ID = fr.Rol_ID where r.Rol_detalle = @rol) and Rol_ID = (SELECT distinct r.Rol_ID from HPBC.Rol r where r.Rol_detalle=@rol)
END
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='existeUsuario' AND type='F')
DROP FUNCTION HPBC.existeUsuario
GO
CREATE FUNCTION HPBC.existeUsuario(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Usuario WHERE UPPER(usuario_username) = @buscado)
	Begin
	return 1
	end
return 0
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='existeDNI' AND type='F')
DROP FUNCTION HPBC.existeDNI
GO
CREATE FUNCTION HPBC.existeDNI(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Cliente WHERE clie_dni = @buscado)
	Begin
	return 1
	end
return 0
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='existeEmail' AND type='F')
DROP FUNCTION HPBC.existeEmail
GO


CREATE FUNCTION HPBC.existeEmail(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Cliente WHERE UPPER(clie_mail) = UPPER(@buscado))
	Begin
	return 1
	end
return 0
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='existeRubro' AND type='F')
DROP FUNCTION HPBC.existeRubro
GO
CREATE FUNCTION HPBC.existeRubro(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Rubro WHERE UPPER(Rubro_detalle) = UPPER(@buscado))
	Begin
	return 1
	end
return 0
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='existeCUIT' AND type='F')
DROP FUNCTION HPBC.existeCUIT
GO
CREATE FUNCTION HPBC.existeCUIT(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Proveedor WHERE UPPER(Provee_CUIT) = UPPER(@buscado))
	Begin
	return 1
	end
return 0
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='existeRS' AND type='F')
DROP FUNCTION HPBC.existeRS
GO
CREATE FUNCTION HPBC.existeRS(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Proveedor WHERE UPPER(Provee_Rs) = UPPER(@buscado))
	Begin
	return 1
	end
return 0
end
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='existeRol' AND type='F')
DROP FUNCTION HPBC.existeRol
GO
CREATE FUNCTION HPBC.existeRol(@buscado varchar(255))
returns Bit
AS
BEGIN
if Exists(SELECT 1 FROM HPBC.Rol WHERE UPPER(Rol_detalle) = UPPER(@buscado))
	Begin
	return 1
	end
return 0
end
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_bajaLogica_Rol' AND type='p')
DROP PROCEDURE HPBC.pr_bajaLogica_Rol
GO
CREATE PROCEDURE HPBC.pr_bajaLogica_Rol(@ABajar int)
AS
BEGIN
UPDATE HPBC.Rol set Rol_Habilitado = 0 
WHERE Rol_ID = @ABajar 
END
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_bajaLogica_Cliente' AND type='p')
DROP PROCEDURE HPBC.pr_bajaLogica_Cliente
GO
CREATE PROCEDURE HPBC.pr_bajaLogica_Cliente(@ABajar int)
AS
BEGIN
UPDATE HPBC.Cliente set clie_habilitado = 0 
WHERE clie_habilitado = @ABajar 
END
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_bajaLogica_Usuario' AND type='p')
DROP PROCEDURE HPBC.pr_bajaLogica_Usuario
GO
CREATE PROCEDURE HPBC.pr_bajaLogica_Usuario(@ABajar int)
AS
BEGIN
UPDATE HPBC.Usuario set usuario_habilitado = 0 
WHERE usuario_id = @ABajar 
END
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='pr_bajaLogica_Proveedor' AND type='p')
DROP PROCEDURE HPBC.pr_bajaLogica_Proveedor
GO
CREATE PROCEDURE HPBC.pr_bajaLogica_Proveedor(@ABajar int)
AS
BEGIN
UPDATE HPBC.Proveedor set Provee_Habilitado = 0 
WHERE Provee_Habilitado = @ABajar 
END
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='comprasDeOfertaRealizadas' AND type='F')
DROP FUNCTION HPBC.comprasDeOfertaRealizadas
GO
CREATE FUNCTION HPBC.comprasDeOfertaRealizadas(@dni int,@codOferta varchar(255))
returns INT
AS
BEGIN
	RETURN (SELECT count(*) from HPBC.Compra 
	where Compra_ID_Clie_Dest = (select clie_ID from HPBC.Cliente WHERE @dni =	clie_dni) 
	and Compra_ID_Oferta = (select Ofe_ID from HPBC.Oferta where @codOferta = Ofe_Codigo))
END
GO


IF EXISTS (SELECT name FROM sysobjects WHERE name='trigger_crear_cupon' AND type='tr')
DROP TRIGGER HPBC.trigger_finalizar_oferta
GO
CREATE TRIGGER HPBC.trigger_crear_cupon
ON HPBC.Compra
AFTER Insert AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM inserted i join HPBC.Cupon c on c.Cupon_ID_Compra = i.Compra_ID)
	BEGIN
		INSERT INTO HPBC.Cupon(Cupon_ID_Compra,Cup_Fecha_Consumo,Cup_Fecha_Venc,Cup_Codigo)
		SELECT i.Compra_ID, null, DATEADD(MM, 1, i.Compra_Fecha), Ofe_Codigo + HPBC.fnBase36(i.Compra_ID) FROM inserted i join HPBC.Oferta on i.Compra_ID_Oferta = Ofe_ID
		
	END
END
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='trigger_compra_facturada' AND type='tr')
DROP TRIGGER HPBC.trigger_compra_facturada
GO
create TRIGGER HPBC.trigger_compra_facturada ON HPBC.Detalle_Fact FOR INSERT
AS 
BEGIN TRANSACTION
UPDATE HPBC.Compra set Compra_Facturada = 1 
WHERE Exists(Select 1 From inserted where Compra_ID = Detalle_ID_Compra) 
COMMIT TRANSACTION
GO