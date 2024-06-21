-- Criar tabela de Categorias
CREATE TABLE Categorias (
    Codigo INT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL
);

CREATE TABLE UtilizadoresCargos (
	CargoId INT PRIMARY KEY NOT NULL,
	CargoNome VARCHAR(255) NOT NULL
);

CREATE TABLE Utilizadores (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Utilizador VARCHAR(255) NOT NULL,
	Senha VARCHAR(255) NOT NULL,
	Cargo INT NOT NULL,
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

-- Criar tabela de Vendas
CREATE TABLE Vendas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CodigoVendedor VARCHAR(50) NOT NULL,
    Zona VARCHAR(255) NOT NULL, --ID
    DataVenda DATE NOT NULL,
    Quantidade INT NOT NULL,
    CodigoProduto VARCHAR(50) NOT NULL,
    ValorVenda DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CodigoVendedor) REFERENCES Vendedores(Codigo),
    FOREIGN KEY (CodigoProduto) REFERENCES Produtos(Codigo)
);

-- Inserir dados na tabela Categorias
INSERT INTO Categorias (Codigo, Nome) VALUES 
(1, 'Computadores e Periféricos'),
(2, 'Smartphones e Acessórios'),
(3, 'Componentes de Hardware');

-- Inserir dados na tabela UtilizadoresCargos
INSERT INTO UtilizadoresCargos (CargoId, CargoNome) VALUES
(1, 'Administrador'),
(2, 'Vendedor');

-- Inserir dados na tabela Utilizadores
INSERT INTO Utilizadores (Utilizador, Senha, Cargo) VALUES
('admin', 'admin', 1),
('vendedor', 'vendedor', 2);

-- Inserir dados na tabela Produtos
INSERT INTO Produtos (Codigo, Nome, CodigoCategoria, Preco) VALUES 
('P001', 'Portátil Lenovo ThinkPad', 1, 1200.00),
('P002', 'Smartphone Samsung Galaxy S21', 2, 900.00),
('P003', 'Monitor Dell 24"', 1, 300.00),
('P004', 'Placa Gráfica NVIDIA RTX 3080', 3, 1500.00),
('P005', 'Teclado Mecânico Logitech', 1, 100.00);

-- Inserir dados na tabela Vendas
INSERT INTO Vendas (CodigoVendedor, Zona, DataVenda, Quantidade, CodigoProduto, ValorVenda) VALUES 
(1, 'N', '2024-01-15', 2, 'P001', 2400.00),
(2, 'S', '2024-02-10', 3, 'P002', 2700.00),
(3, 'C', '2024-03-05', 1, 'P003', 300.00),
(1, 'N', '2024-04-20', 5, 'P005', 500.00),
(2, 'S', '2024-05-25', 1, 'P004', 1500.00);

-- Inserir dados na tabela Vendedores
INSERT INTO Vendedores (Codigo, Nome, Comissao) VALUES 
(1, 'João Silva', 5.00),
(2, 'Maria Oliveira', 7.50),
(3, 'Carlos Souza', 6.00),
(4, 'Dummy', '5.00'),
(5, 'Dummy', '5.00'),
(6, 'Dummy', '5.00'),
(7, 'Dummy', '5.00'),
(8, 'Dummy', '5.00'),
(9, 'Dummy', '5.00'),
(10, 'Dummy', '5.00'),
(11, 'Dummy', '5.00'),
(12, 'Dummy', '5.00'),
(13, 'Dummy', '5.00'),
(14, 'Dummy', '5.00');
