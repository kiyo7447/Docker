# ベースイメージとしてUbuntuを指定
FROM ubuntu:latest

# 必要なツールをインストールし、パッケージを更新する
RUN apt-get update && \
    apt-get install -y nginx curl && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# ローカルにあるindex.htmlファイルをコピーする
COPY index.html /var/www/html/

# nginxのデフォルト設定を上書きする
RUN echo "\
server {\
    listen 80 default_server;\
    listen [::]:80 default_server;\

    root /var/www/html;\
    index index.html;\

    server_name _;\

    location / {\
        try_files \$uri \$uri/ =404;\
    }\
}" > /etc/nginx/sites-available/default

# 環境変数TEST_ENVをHOGEHOGEという値で設定する
ENV TEST_ENV=HOGEHOGE

# 80番ポートを公開する
EXPOSE 80

# nginxをフォアグラウンドで実行する
CMD ["nginx", "-g", "daemon off;"]
