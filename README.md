# MinimalAPI-AspNetCore-SQLServer

Aplicação desenvolvida para a atividade 'Persistência de Dados' da matéria Tecnologias para Análise e Desenvolvimento de Sistemas - G1/T1 - 4ºP/40H - 2024/2.  


## Requisitos  

Ser baseado no objeto Produto com os seguintes atributos:   
- Nome;
- Código;
- Preço;
- Descrição;
- QuantidadeEmEstoque;
- Avaliação;
- Categoria.

Possuir rotas para:  

- Criação de dados com Post;
- Leitura de todos os dados do banco com Get;
- Leitura de dados por código do produto com Get;
- Leitura de dados por categoria com Get;
- Atualização de informações com Put ou Patch; e
- Exclusão de elementos com Delete. 


## Tecnologias utilizadas  

Foi utilizando o Microsoft.EntityFrameworkCore.SqlServer, este provedor de banco de dados permite que o Entity Framework Core seja usado com o Microsoft SQL Server; já o Microsoft.EntityFrameworkCore.Tools são usadas principalmente para gerenciar Migrações e para criar scaffolds de DbContexttipos de entidade por meio de engenharia reversa do esquema de um banco de dados.

Para esta aplicação foram utilizados os seguintes pacotes:  

-  **Microsoft.EntityFrameworkCore.SqlServer**
-  **Microsoft.EntityFrameworkCore.Tools**
  
