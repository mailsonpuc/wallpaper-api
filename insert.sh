#!/bin/bash

# Nome do banco de dados SQLite
DB_NAME="app.db"

# Comando SQL para inserir dados
SQL_COMMAND="INSERT INTO WallpaperItems (WallpaperLink) VALUES 
$(cat "dados2.txt")
"


# Executa o comando SQL
sqlite3 "$DB_NAME" "$SQL_COMMAND"

