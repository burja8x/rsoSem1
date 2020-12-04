FROM microsoft/dotnet:2.1-aspnetcore-runtime
RUN ls
RUN pwd
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY /app .
RUN ls
RUN pwd
RUN ls app
ENTRYPOINT ["dotnet", "RsoSem1.dll"]