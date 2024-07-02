-- Criar tabela de Categorias
CREATE TABLE Categorias (
    Codigo INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(255) NOT NULL
);

-- Criar tabela de UtilizadoresCargos
CREATE TABLE UtilizadoresCargos (
    CargoId INT PRIMARY KEY NOT NULL,
    CargoNome VARCHAR(255) NOT NULL
);

-- Criar tabela de Utilizadores
CREATE TABLE Utilizadores (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Utilizador VARCHAR(255) NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    Cargo INT NOT NULL,
    flag INT,
    FOREIGN KEY (Cargo) REFERENCES UtilizadoresCargos(CargoId)
);

-- Criar tabela de Vendedores
CREATE TABLE Vendedores (
    Codigo VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Comissao DECIMAL(10, 2) NOT NULL
);

-- Criar tabela de Produtos
CREATE TABLE Produtos (
    Codigo VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    CodigoCategoria INT NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CodigoCategoria) REFERENCES Categorias(Codigo)
);

-- Criar tabela de Zonas
CREATE TABLE Zonas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NomeZona VARCHAR(10),
    Abreviatura VARCHAR(1)
);

-- Criar tabela de Vendas
CREATE TABLE Vendas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CodigoVendedor VARCHAR(50) NOT NULL,
    Zona INT NOT NULL, --ID
    DataVenda DATE NOT NULL,
    Quantidade INT NOT NULL,
    CodigoProduto VARCHAR(50) NOT NULL,
    ValorVenda DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CodigoVendedor) REFERENCES Vendedores(Codigo),
    FOREIGN KEY (CodigoProduto) REFERENCES Produtos(Codigo),
    FOREIGN KEY (Zona) REFERENCES Zonas(Id)
);


-- Inserir dados na tabela Categorias
INSERT INTO Categorias (Nome) VALUES 
('Computadores e Perif�ricos'),
('Smartphones e Acess�rios'),
('Componentes de Hardware'),
('Impressoras e Scanners'),
('Acess�rios de Computador'),
('Armazenamento Externo');

-- Inserir dados na tabela UtilizadoresCargos
INSERT INTO UtilizadoresCargos (CargoId, CargoNome) VALUES
(1, 'Administrador'),
(2, 'Vendedor');

-- Inserir dados na tabela Utilizadores
INSERT INTO Utilizadores (Utilizador, Senha, Cargo, flag) VALUES
('admin', 'admin', 1, 0),
('vendedor', 'vendedor', 2, 0);

-- Inserir dados na tabela Produtos
INSERT INTO Produtos (Codigo, Nome, CodigoCategoria, Preco) VALUES 
('P001', 'Port�til Lenovo ThinkPad', 1, 1200.00),
('P002', 'Smartphone Samsung Galaxy S21', 2, 900.00),
('P003', 'Monitor Dell 24"', 1, 300.00),
('P004', 'Placa Gr�fica NVIDIA RTX 3080', 3, 1500.00),
('P005', 'Teclado Mec�nico Logitech', 1, 100.00),
('P006', 'Impressora HP LaserJet', 4, 400.00),
('P007', 'Teclado sem Fio Microsoft', 5, 50.00),
('P008', 'HD Externo Seagate 1TB', 6, 80.00),
('P009', 'Mouse Gamer Razer', 5, 70.00),
('P010', 'SSD Kingston 500GB', 6, 120.00);

-- Inserir dados na tabela Vendedores
INSERT INTO Vendedores (Codigo, Nome, Comissao) VALUES 
('1', 'Jo�o Silva', 5.00),
('2', 'Maria Oliveira', 7.50),
('3', 'Carlos Souza', 6.00),
('4', 'Ana Costa', 6.50),
('5', 'Pedro Santos', 5.75),
('6', 'Marta Fernandes', 7.00);

-- Inserir dados na tabela Zonas
INSERT INTO Zonas (NomeZona, Abreviatura) VALUES
('Norte', 'N'),
('Centro', 'C'),
('Sul', 'S');

-- Inserir dados na tabela Vendas
INSERT INTO Vendas (CodigoVendedor, Zona, DataVenda, Quantidade, CodigoProduto, ValorVenda) VALUES 
('1', 1, '2024-01-15', 2, 'P001', 2400.00),
('2', 1, '2024-02-10', 3, 'P002', 2700.00),
('3', 2, '2024-03-05', 1, 'P003', 300.00),
('1', 3, '2024-04-20', 5, 'P005', 500.00),
('2', 2, '2024-05-25', 1, 'P004', 1500.00),
('4', 2, GETDATE(), 2, 'P006', 800.00),
('5', 3, GETDATE(), 4, 'P007', 200.00),
('6', 2, GETDATE(), 1, 'P008', 80.00),
('4', 1, GETDATE(), 3, 'P009', 210.00),
('5', 2, GETDATE(), 2, 'P010', 240.00);
