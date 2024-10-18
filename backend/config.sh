clear

# dotnet add package Microsoft.EntityFrameworkCore
# dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
# dotnet add package Microsoft.EntityFrameworkCore.Design
# dotnet add package Microsoft.EntityFrameworkCore.SqlServer
# dotnet add package Microsoft.EntityFrameworkCore.Tools
# dotnet add package Microsoft.EntityFrameworkCore.SQLite


# dotnet aspnet-codegenerator controller \
# -name WallpaperItemsController         \
# -async -api                            \
# -m WallpaperItem                       \
# -dc BancoDeDadosContext                \
# -outDir Controllers                    \


# dotnet aspnet-codegenerator controller  \
# -name MarcarAulasController             \ # <- NOME_DO_CONTROLADOR
# -m MarcarAula                           \ # <- NOME_DO_MODELO
# -dc projeto.Data.projetoContext         \ # <- O CONTEXTO DE DADOS
# --relativeFolderPath Controllers        \ # <- O caminho da pasta de saída relativa para criar os arquivos.
# --useDefaultLayout                      \ # <- O layout padrão deve ser usado para as exibições.
# --referenceScriptLibraries              \ # <- Adiciona _ValidationScriptsPartial para Editar e Criar páginas.
# --databaseProvider sqlite               \ # <- USAR O BANCO


dotnet ef migrations add InitialCreate
dotnet ef database update