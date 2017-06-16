FROM jetbrains/teamcity-minimal-agent
MAINTAINER Eik Emil Christensen <denie@eikc.dk>

# Install dependencies
RUN apt-get install apt-transport-https ca-certificates -y

RUN sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list' \
    && apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893 \
    && apt-get update \
    && apt-get install dotnet-dev-1.0.0-preview2.1-003177 -y
