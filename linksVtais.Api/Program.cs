var builder = WebApplication.CreateBuilder(args);

//antes de criar o app vamos colocar os comandos 
//para o OpenApi e swagger explorar as interfaces
//e criar a documentação necessario automaticamente
//O Front end do swagger é gerado em tempo de compilacao
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( x=>{
    x.CustomSchemaIds(y=>y.FullName); //irá colocar a classe + namespace
}); 

var app = builder.Build();
//após criar o app não esquecer de usar o swager dentro dele
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.Run();
