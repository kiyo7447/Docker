# 依頼
ubuntuで作ってください。
Webでindexhtmlの内容を80番ポートで返すようにしてください。



``` bash
docker build --tag dockerfile_ubuntu .

# 自作イメージからコンテナを起動
docker run -d -p 8080:80 --name ubuntu_v2 dockerfile_ubuntu

curl localhost:8080
```

# 依頼
エラーが出てうまく起動しません。  

2023-03-18 23:59:32 nginx: [emerg] unknown directive "server" in /etc/nginx/sites-enabled/default:1  

## 結果
→対応されました。  
defaultファイルを使ったパターンでは動かなかったわけですが、原因が不明でした。  

# Docker history
$ docker history dockerfile_ubuntu
IMAGE          CREATED          CREATED BY                                      SIZE      COMMENT
aecbc84f9006   4 minutes ago    CMD ["nginx" "-g" "daemon off;"]                0B        buildkit.dockerfile.v0
<missing>      4 minutes ago    EXPOSE map[80/tcp:{}]                           0B        buildkit.dockerfile.v0
<missing>      4 minutes ago    ENV TEST_ENV=HOGEHOGE                           0B        buildkit.dockerfile.v0
<missing>      4 minutes ago    RUN /bin/sh -c echo "server {    listen 80 d…   190B      buildkit.dockerfile.v0
<missing>      18 minutes ago   COPY index.html /var/www/html/ # buildkit       41B       buildkit.dockerfile.v0
<missing>      18 minutes ago   RUN /bin/sh -c apt-get update &&     apt-get…   70MB      buildkit.dockerfile.v0
<missing>      19 months ago    /bin/sh -c #(nop)  CMD ["bash"]                 0B    

<missing>      19 months ago    /bin/sh -c #(nop) ADD file:524e8d93ad65f08a0…   72.8MB
