using ExemploGRPC.Server;
using ExemploGRPC.Server.Services;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7053/");
var client = new Greeter.GreeterClient(channel);
var req = new HelloRequest()
{
    Name = "Cachorro!"
};

var res = await client.SayHelloAsync(req);

Console.WriteLine(res.Message);
Console.ReadKey();