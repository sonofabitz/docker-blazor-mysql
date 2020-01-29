# docker run --rm --link mysql-netcore -p 5001:80 --name blazor blazor-docker
docker run `
 --rm `
--link mysql-netcore `
-p 5001:80 `
-e "DBPassword=password" `
-e "DBServer=mysql-netcore" `
-e "DBDatabase=MusicStoreDB" `
-e "DBUser=root" `
--name blazor `
blazor-docker