using System.DirectoryServices.Protocols;
using System.Net;

var credentials = new NetworkCredential("CN=user01,OU=users,DC=example,DC=org", "Зфыы123;");
//var credentials = new NetworkCredential("CN=user02,OU=users,DC=example,DC=org", "Pass123$");
//var credentials = new NetworkCredential("user02", "Pass123$");

var identifier = new LdapDirectoryIdentifier("localhost", 1389);
using var connection = new LdapConnection(identifier, credentials, AuthType.Basic);
connection.SessionOptions.ProtocolVersion = 3;
connection.Bind(); // Throws Invalid Credentials Error

Console.WriteLine("Successful bind");
