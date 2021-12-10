#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

DROP DATABASE if EXISTS gcfainsta ;
CREATE DATABASE gcfainsta ;
USE gcfainsta ;

#------------------------------------------------------------
# Table: dbadmin
#------------------------------------------------------------

CREATE TABLE dbadmin(
        IdAdmin Int  Auto_increment  NOT NULL ,
        Email   Varchar (200) NOT NULL ,
        Mdp     Varchar (100) NOT NULL ,
        Num     Int NOT NULL
        ,CONSTRAINT dbadmin_PK PRIMARY KEY (IdAdmin)
)ENGINE=InnoDB;


INSERT INTO dbadmin VALUES
(null, "a@gmail.com", "123", "0606060606"),
(null, "a@gmail.com", "456", "0706060606");


#------------------------------------------------------------
# Table: gestion
#------------------------------------------------------------

CREATE TABLE gestion(
        IdStatus Int  Auto_increment  NOT NULL ,
        Status   Bool NOT NULL
        ,CONSTRAINT gestion_PK PRIMARY KEY (IdStatus)
)ENGINE=InnoDB;

INSERT INTO gestion VALUES (null, true);

#------------------------------------------------------------
# Table: dbcandidat
#------------------------------------------------------------

CREATE TABLE dbcandidat(
        IdCandidat  Int  Auto_increment  NOT NULL ,
        LastName    Varchar (50) NOT NULL ,
        FirstName   Varchar (50) NOT NULL ,
        Age         Int NOT NULL ,
        Birthday    Date NOT NULL ,
        Adress      Varchar (200) NOT NULL ,
        City        Varchar (50) NOT NULL ,
        Postcode    Int NOT NULL ,
        Email       Varchar (50) NOT NULL ,
        OvrAverage  Varchar (50) NOT NULL ,
        PhoneNumber Int NOT NULL ,
        IdStatus    Int
        ,CONSTRAINT dbcandidat_PK PRIMARY KEY (IdCandidat)

        ,CONSTRAINT dbcandidat_gestion_FK FOREIGN KEY (IdStatus) REFERENCES gestion(IdStatus)
)ENGINE=InnoDB;

INSERT INTO dbcandidat VALUES 
(null, "Pinot","Alexandre", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "api@gmail.com", "15", 0625331145, 1),
(null, "Dai","Clement", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "dac@gmail.com", "15", 0625331145, 1),
(null, "Dai","Lucile", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "dal@gmail.com", "15", 0625331145, 1),
(null, "Mcdo","Geoffrey", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "mge@gmail.com", "15", 0625331145, 1),
(null, "Mcdo","Julie", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "mju@gmail.com", "15", 0625331145, 1),
(null, "Machin","Bernard", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "mab@gmail.com", "15", 0625331145, 1),
(null, "Machine","Helene", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "mah@gmail.com", "15", 0625331145, 1),
(null, "Ping","Chen", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "pic@gmail.com", "15", 0625331145, 1),
(null, "Pong","Shen", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "pos@gmail.com", "15", 0625331145, 1),
(null, "Poop","Thor", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "pot@gmail.com", "15", 0625331145, 1),
(null, "Damm","Phillipe", 28, "2000-12-12", "Les Lilas", "Les Lilas", "93260", "dap@gmail.com", "15", 0625331145, 1);;


#------------------------------------------------------------
# Table: do
#------------------------------------------------------------

CREATE TABLE do(
        IdAdmin  Int NOT NULL ,
        IdStatus Int NOT NULL
        ,CONSTRAINT do_PK PRIMARY KEY (IdAdmin,IdStatus)

        ,CONSTRAINT do_dbadmin_FK FOREIGN KEY (IdAdmin) REFERENCES dbadmin(IdAdmin)
        ,CONSTRAINT do_gestion0_FK FOREIGN KEY (IdStatus) REFERENCES gestion(IdStatus)
)ENGINE=InnoDB;
