# ベースイメージとしてnginxを指定
FROM nginx:latest

# ローカルにあるindex.htmlファイルをコピーする
COPY index.html /usr/share/nginx/html/

# 必要なツールをインストールし、パッケージを更新する
RUN apt-get update && \
    apt-get install -y curl && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# 環境変数TEST_ENVをHOGEHOGEという値で設定する
ENV TEST_ENV=HOGEHOGE
