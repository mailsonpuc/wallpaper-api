#!/bin/bash

# Arquivo de entrada que contém os links
ARQUIVO="dados.json"

# Usando grep para encontrar links com .png ou .jpg
grep -Eo 'http[s]?://[^ ]+\.(png|jpg|jpeg)' "$ARQUIVO"


# tem que sair assim
# (https://wallpaper4k.top/wp-content/uploads/2023/12/Soft-grey-aesthetic-wallpaper.jpg),

