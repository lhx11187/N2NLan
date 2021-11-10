set serviceName=N2NService

sc stop   %serviceName% 
sc delete %serviceName% 

pause