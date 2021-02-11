# hada-p1
Hada practica 1 b --> remote repositories


# EADA - Practica 1b : Uso de git - repositorios remotos  
  
## P1:
'git push -u origin master' sube la rama master; teams sube la rama master

## P2:
Al pulsar Comparar se ejecuta un 'git diff' y teams muestra las diferencias entre los archivos

## P3:
Al sincronizar el repositorio local con el remoto ya se pueden ver los cambios en github. 'git stash' guarda los cambios solo en el repositorio local

## P4:
'Hacer cambios staged' significa guardar los cambios en el repositorio local  Su comando equivalente seria 'git add * && git commit -m "$(MSG)" && git stash'

## P5:
'Hacer cambios staged e insertar' quiere decir guardar los cambios en local y subirlos al remoto  Su comando equivalente seria 'git add * && git commit -m "$(MSG)" && git stash && git push -u origin master'

## P6:
'Hacer cambios staged y sincronizar' quiere decir guardar los cambios en local y hacer iguales los dos repositorios  Su comando equivalente seria 'git add * && git commit -m "$(MSG)" && git stash && git pull && git fetch -u origin master'
