# Sistema de Controle de Acesso

Este projeto foi desenvolvido como parte da **atividade prática da disciplina de Programação**, orientada pelo professor Well, com o objetivo de aplicar conceitos de programação orientada a objetos, interface gráfica com Windows Forms, e manipulação de banco de dados com MySQL.

---

## 🧾 Objetivo da Atividade

Criar um sistema funcional de **controle de acesso** com:

- Separação clara entre a **interface gráfica (Windows Forms)** e a **lógica de negócio (Class Library)**
- Cadastro e autenticação de usuários
- Registro de entradas e saídas com data/hora
- Consulta e filtragem de registros

---

## 🗂 Estrutura da Solução

A solução Visual Studio é composta por dois projetos separados:

- **ControleAcesso.Core** (Class Library):
  - Entidades: `Usuario`, `RegistroAcesso`
  - Regras de negócio: `Autenticador`, conexão com o banco
  - Lógica de autenticação e persistência

- **ControleAcesso.UI** (Windows Forms):
  - Telas do sistema: Login, Cadastro de Usuário, Controle de Acesso
  - Interface com o usuário
  - Consome as classes e serviços da biblioteca

---

## 🧩 Funcionalidades Implementadas

✔ Cadastro de usuários com validação dos campos  
✔ Validação de CPF com máscara  
✔ Senha criptografada com `MD5` (simulação)  
✔ Tela de login com validação no banco de dados  
✔ Registro de entrada e saída com data/hora  
✔ Exibição dos registros em `DataGridView`  
✔ Filtros por nome e data com `DateTimePicker`  

---

## 🛠 Tecnologias Utilizadas

- **C#** com Windows Forms (.NET)
- **MySQL** como banco de dados local
- Biblioteca **MySql.Data**
- Controles da interface:
  - `TextBox`, `ComboBox`, `MaskedTextBox`
  - `DataGridView`, `DateTimePicker`, `MessageBox`

---

## 💾 Estrutura do Banco de Dados

Banco de dados: `atividade1`  
Tabelas:

```sql
CREATE DATABASE IF NOT EXISTS atividade1;
USE atividade1;

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    cpf VARCHAR(14),
    tipoUsuario VARCHAR(20),
    senha VARCHAR(32),
    foto BLOB,
);

CREATE TABLE registro_acesso (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_usuario INT,
    DataHora DATETIME DEFAULT CURRENT_TIMESTAMP,
    TipoOperacao ENUM ('Entrada', 'Saída'),
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id)
);
