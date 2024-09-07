using Microsoft.EntityFrameworkCore;
using Minimal_API.DataBase;
using Minimal_API.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Context>();

var app = builder.Build();

app.MapGet("/Produto", async (Context db) =>
await db.Produtos.ToListAsync<Produto>()
);

app.MapGet("/Produto/Codigo/{codigo}", async (Context db, long codigo) =>
{
    Produto produtoDb = await db.Produtos.FirstAsync(i => i.Codigo.Equals(codigo));
    return produtoDb is null ?  Results.NotFound(): Results.Ok(produtoDb);
}
);

app.MapGet("/Produto/Categoria/{categoria}", async (Context db, string categoria) =>
await db.Produtos.Where(p => p.Categoria.Equals(categoria)).ToListAsync<Produto>()
);

app.MapPost("/Produto", async (Context db, Produto produto) =>
{
    db.Produtos.Add(produto);
    await db.SaveChangesAsync();
    return Results.Created($"/Produto/{produto.Codigo}", produto);
});

app.MapPut("/Produto/{id}", async (Context db, int id, Produto produto) =>
{
    Produto produtoDb = await db.Produtos.FindAsync(id);
    if (produtoDb is null) return Results.NotFound();
    else
    {
        produtoDb.Nome = produto.Nome;
        produtoDb.Codigo = produto.Codigo;
        produtoDb.Preco = produto.Preco;
        produtoDb.Descricao = produto.Descricao;
        produtoDb.Categoria = produto.Categoria;

        await db.SaveChangesAsync();

        return Results.NoContent();
    }
});

app.MapDelete("/Produto/{id}", async (Context db, int id) =>
{
    if (await db.Produtos.FindAsync(id) is Produto produto)
    {
        db.Produtos.Remove(produto);
        await db.SaveChangesAsync();
        return Results.Ok();
    }
    else return Results.NotFound();
});

app.Urls.Add("https://localhost:3000/");

app.Run();
