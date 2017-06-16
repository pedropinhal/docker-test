FROM jetbrains/teamcity-minimal-agent
LABEL maintainer "mappies@gmail.com"

# Install dependencies
RUN apt-get install apt-transport-https ca-certificates -y

# Its base image is based on Ubuntu 15 which needs libicu52 to install dotnet core.
# Source: https://github.com/aspnet/dnx/issues/3059#issuecomment-150672608
RUN apt-get install wget -y
RUN wget http://security.ubuntu.com/ubuntu/pool/main/i/icu/libicu52_52.1-8ubuntu0.2_amd64.deb
RUN dpkg -i libicu52_52.1-8ubuntu0.2_amd64.deb

# Add the dotnet apt-get feed
RUN sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ trusty main" > /etc/apt/sources.list.d/dotnetdev.list'
RUN apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893
RUN apt-get update

# Install dotnet core SDK
RUN apt-get install dotnet-dev-1.0.0-preview2.1-003177 -y
