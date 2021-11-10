set serviceName=N2NService
set serviceFilePath=D:\Project\N2NLan\N2NService\bin\Debug\net5.0\N2NService.exe
set serviceDescription=N2N客户端服务

sc create %serviceName%  BinPath=%serviceFilePath%
sc config %serviceName%    start=auto  
sc description %serviceName%  %serviceDescription%
sc start  %serviceName%
pause