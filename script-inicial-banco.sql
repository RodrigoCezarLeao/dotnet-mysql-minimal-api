CREATE TABLE Voluntario (
ID_Voluntario INT PRIMARY KEY,
Nome VARCHAR(100),
CPF INT,
Telefone_PK INT,
Endereco_ VARCHAR(100),
CEP VARCHAR(100),
Data_Nascimento_ DATE,
E_mail VARCHAR(100),
Senha VARCHAR(100),
Profissao VARCHAR(100),
Descricao_Pessoal_ VARCHAR(100),
Formacao_Academica VARCHAR(100)
);

CREATE TABLE Telefone (
ID INT NOT NULL PRIMARY KEY,
Telefone VARCHAR(100)
);


CREATE TABLE ONG (
ID_ONG INT PRIMARY KEY,
Nome VARCHAR(100),
CNPJ VARCHAR(100),
Endreco VARCHAR(100),
FK_Telefone_Telefone_PK VARCHAR(100),
FK_Area_Atuacao_Area_Atuacao_PK VARCHAR(100),
Historico VARCHAR(100),
FK_Necessidades_Necessidades_PK VARCHAR(100),
E_mail VARCHAR(100),
Senha VARCHAR(100)
);


CREATE TABLE Chat (
ID_Chat INT,
Mensagem VARCHAR(100),
Data_Hora DATE
);


CREATE TABLE Match_Demonstra_Interesse (
ID_Match INT PRIMARY KEY,
Data_Match DATE,
fk_Voluntario_ID_Voluntario INT,
fk_ONG_ID_ONG INT
);






CREATE TABLE Area_Atuacao_ (
Area_Atuacao__PK VARCHAR(100) NOT NULL PRIMARY KEY,
Area_Atuacao_ VARCHAR(100)
);


CREATE TABLE Necessidades (
Necessidades_PK VARCHAR(100) NOT NULL PRIMARY KEY,
Necessidades VARCHAR(100)
);



--------------------------------------------------------------

insert into Voluntario values
('1', 'Gabriel', '1234', 1, 'Rua dos nerdolas', '10.230-423', '1990-01-01', 'gabriel@email.com', 'gab123', 'Programador', 'Eu sou doente de fazer um grupo tão ruim assim', 'Graduação em Curso')

insert into Telefone values (1, '99999-0000')


insert into Voluntario values
('2', 'Rodrigo', '5678', 2, 'Rua dos nerdolas 2', '11.330-443', '1990-01-20', 'rodrigo@email.com', 'rod123', 'Programador', 'Eu sou doente de fazer um grupo tão ruim assim', 'Graduação Completa')

insert into Telefone values (2, '98888-0000')