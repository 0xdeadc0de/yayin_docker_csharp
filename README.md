Gereksinimler:
1. Docker ->
    Windows için      -> https://desktop.docker.com/win/stable/Docker%20Desktop%20Installer.exe
    Diğer platformlar -> https://www.docker.com/products/docker-desktop
2. Git    -> https://git-scm.com/download/
3. Heroku -> https://devcenter.heroku.com/articles/heroku-cli#download-and-install

1. Dockerfile oluştur
2. dockerignore ve gitignore dosyalarını oluştur
3. Aşağıdaki komutlar çalıştır

git init

docker build -t UYGULAMAMIN_ISMI .

4. heroku platformuna kayıt ol ve yeni bir app oluştur
    -> https://heroku.com
5. Aşağıdaki komutları çalıştır.

heroku container:login

heroku container:push -a HEROKU_APP_ISMIN worker

heroku container:release -a HEROKU_APP_ISMIN worker

