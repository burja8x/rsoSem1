FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

COPY --from=publish /app .
ENTRYPOINT ["dotnet", "RsoSem1.dll"]