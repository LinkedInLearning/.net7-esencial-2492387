var message = $""" 

Estás viendo el curso ".NET esencial" 
de Rodrigo Díaz Concha
en //LinkedIn Learning\\.

Tu versión de .NET es: {AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName}

""";


System.Console.WriteLine(message);