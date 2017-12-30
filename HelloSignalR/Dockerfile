FROM microsoft/aspnetcore-build
EXPOSE 80
WORKDIR /app
COPY . .
RUN dotnet restore
ENTRYPOINT ["dotnet", "run"]