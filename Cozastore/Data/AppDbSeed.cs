using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Cozastore.Models;

namespace CozaStore.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Cor
        List<Cor> cores = new() {
            new Cor() {
                Id = 1,
                Nome = "Preto",
                CodigoHexa = "#222"
            },
            new Cor() {
                Id = 2,
                Nome = "Azul",
                CodigoHexa = "#4272d7"
            },
            new Cor() {
                Id = 3,
                Nome = "Cinza",
                CodigoHexa = "#b3b3b3"
            },
            new Cor() {
                Id = 4,
                Nome = "Verde",
                CodigoHexa = "#00ad5f"
            },
            new Cor() {
                Id = 5,
                Nome = "Vermelho",
                CodigoHexa = "#fa4251"
            },
            new Cor() {
                Id = 6,
                Nome = "Branco",
                CodigoHexa = "#fff"
            }
        };
        builder.Entity<Cor>().HasData(cores);
        #endregion

        #region Populate Categoria
        List<Categoria> categorias = new() {
            new Categoria() {
                Id = 1,
                Nome = "Feminina",
                Foto = @"images/categorias/1.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 2,
                Nome = "Masculina",
                Foto = @"images/categorias/2.jpg",
                Filtrar = true,
                Banner = true
            },
            new Categoria() {
                Id = 3,
                Nome = "Acessórios",
                Foto = @"images/categorias/3.jpg",
                Filtrar = false,
                Banner = true
            },
            new Categoria() {
                Id = 4,
                Nome = "Bolsas",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaMaeId = 3
            },
            new Categoria() {
                Id = 5,
                Nome = "Calçados",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaMaeId = 3
            },
            new Categoria() {
                Id = 6,
                Nome = "Relógios",
                Foto = "",
                Filtrar = true,
                Banner = false,
                CategoriaMaeId = 3
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion

        #region Populate Tamanho
        List<Tamanho> tamanhos = new() {
            new Tamanho() {
                Id = 1,
                Sigla = "P",
                Nome = "Pequeno"
            },
            new Tamanho() {
                Id = 2,
                Sigla = "M",
                Nome = "Médio"
            },
            new Tamanho() {
                Id = 3,
                Sigla = "G",
                Nome = "Grande"
            },
            new Tamanho() {
                Id = 4,
                Sigla = "GG",
                Nome = "Extra Grande"
            }
        };
        builder.Entity<Tamanho>().HasData(tamanhos);
        #endregion

        #region Populate Produtos
        List<Produto> produtos = new() {
            new Produto() {
                Id = 1,
                Nome = "Camiseta Esprit Ruffle",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 20.64M,
                PrecoDesconto = 20.64M,
                SKU = "CAM-01",
                Destaque = true,
                CategoriaId = 1
            },
            new Produto() {
                Id = 2,
                Nome = "Camiseta Herschel supply",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 35.31M,
                PrecoDesconto = 35.31M,
                SKU = "CAM-02",
                Destaque = true,
                CategoriaId = 1
            },
            new Produto() {
                Id = 3,
                Nome = "Camiseta Quadriculada",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 25.50M,
                PrecoDesconto = 25.50M,
                SKU = "CAM-03",
                Destaque = true,
                CategoriaId = 2
            },
            new Produto() {
                Id = 4,
                Nome = "Casaco Classic Trench",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 75.25M,
                PrecoDesconto = 75.25M,
                SKU = "CAS-01",
                Destaque = true,
                CategoriaId = 1
            },
            new Produto() {
                Id = 5,
                Nome = "Lightweight Jacket",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 53.0M,
                PrecoDesconto = 53.0M,
                SKU = "COJ-01",
                Destaque = true,
                CategoriaId = 2
            },
            new Produto() {
                Id = 6,
                Nome = "Femme T-Shirt In Stripe",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 25.85M,
                PrecoDesconto = 25.85M,
                SKU = "CAM-06",
                Destaque = true,
                CategoriaId = 1
            },
            new Produto() {
                Id = 7,
                Nome = "Camiseta Herschel supply",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 63.16M,
                PrecoDesconto = 63.16M,
                SKU = "CAM-09",
                Destaque = true,
                CategoriaId = 2
            },
            new Produto() {
                Id = 8,
                Nome = "Camiseta T-Shirt with Sleeve",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 18.49M,
                PrecoDesconto = 18.49M,
                SKU = "CAM-14",
                Destaque = true,
                CategoriaId = 1
            },
            new Produto() {
                Id = 9,
                Nome = "Relógio Vintage Classic",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 93.20M,
                PrecoDesconto = 93.20M,
                SKU = "REL-01",
                Destaque = true,
                CategoriaId = 6
            },
            new Produto() {
                Id = 10,
                Nome = "Tênis All Star Hi Plimsolls",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 75.0M,
                PrecoDesconto = 75.0M,
                SKU = "CAL-09",
                Destaque = true,
                CategoriaId = 5
            },
            new Produto() {
                Id = 11,
                Nome = "Cinto de Couro",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 63.15M,
                PrecoDesconto = 63.15M,
                SKU = "CIN-04",
                Destaque = true,
                CategoriaId = 3
            },
            new Produto() {
                Id = 12,
                Nome = "Mini Silver Mesh Watch",
                DescricaoResumida = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat",
                DescricaoCompleta = "Aenean sit amet gravida nisi. Nam fermentum est felis, quis feugiat nunc fringilla sit amet. Ut in blandit ipsum. Quisque luctus dui at ante aliquet, in hendrerit lectus interdum. Morbi elementum sapien rhoncus pretium maximus. Nulla lectus enim, cursus et elementum sed, sodales vitae eros. Ut ex quam, porta consequat interdum in, faucibus eu velit. Quisque rhoncus ex ac libero varius molestie. Aenean tempor sit amet orci nec iaculis. Cras sit amet nulla libero. Curabitur dignissim, nunc nec laoreet consequat, purus nunc porta lacus, vel efficitur tellus augue in ipsum. Cras in arcu sed metus rutrum iaculis. Nulla non tempor erat. Duis in egestas nunc.",
                Preco = 86.85M,
                PrecoDesconto = 86.85M,
                SKU = "REL-04",
                Destaque = true,
                CategoriaId = 6
            }
        };
        builder.Entity<Produto>().HasData(produtos);


        List<ProdutoFoto> produtoFotos = new();
        for (int i = 1; i <= 12; i++)
            produtoFotos.Add(new ProdutoFoto()
            {
                Id = i,
                ProdutoId = i,
                ArquivoFoto = $"/images/produtos/{i}/1.jpg",
                Destaque = true
            });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 13,
            ProdutoId = 5,
            ArquivoFoto = @"/images/produtos/5/2.jpg",
            Destaque = false
        });
        produtoFotos.Add(new ProdutoFoto()
        {
            Id = 14,
            ProdutoId = 5,
            ArquivoFoto = $"/images/produtos/5/3.jpg",
            Destaque = false
        });
        builder.Entity<ProdutoFoto>().HasData(produtoFotos);

        List<Estoque> produtoEstoque = new();
        int id = 1;
        for (int p = 1; p <= 8; p++)
            for (byte c = 1; c <= 6; c++)
                for (byte t = 1; t <= 4; t++)
                {
                    produtoEstoque.Add(new Estoque()
                    {
                        Id = id,
                        ProdutoId = p,
                        CorId = c,
                        TamanhoId = t,
                        QtdeEstoque = new Random().Next(50)
                    });
                    id += 1;
                }
        builder.Entity<Estoque>().HasData(produtoEstoque);
        #endregion

        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Funcionário",
               NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@cozastore.com",
                NormalizedEmail = "ADMIN@COZASTORE.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "José Antonio Gallo Junior",
                DataNascimento = DateTime.Parse("05/08/1981"),
                Foto = "/img/users/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}