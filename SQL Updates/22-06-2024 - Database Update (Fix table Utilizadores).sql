-- Drop da table Utilizadores porque faltava o IDENTITY no campo ID
DROP TABLE Utilizadores;

-- Criação da Nova tabela Utilizadores, já com o campo corrigido
CREATE TABLE Utilizadores (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Utilizador VARCHAR(255) NOT NULL,
	Senha VARCHAR(255) NOT NULL,
	Cargo INT NOT NULL,
	FOREIGN KEY (Cargo) REFERENCES UtilizadoresCargos(CargoId)
);

-- Inserir dados na tabela Utilizadores
INSERT INTO Utilizadores (Utilizador, Senha, Cargo) VALUES
('admin', 'admin', 1),
('vendedor', 'vendedor', 2);

ALTER TABLE Utilizadores
ADD flag int; 