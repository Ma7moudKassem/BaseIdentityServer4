using BaseIdentityServer4.Api.Constant;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//Jwt bearar config
builder.Services.AddAuthentication(CONST_JWT_BEARAR_CONFIG.DEFAULT_SCHEMA)
                .AddJwtBearer(CONST_JWT_BEARAR_CONFIG.DEFAULT_SCHEMA, option => 
                {
                    option.Authority = CONST_JWT_BEARAR_CONFIG.AUTHORITY;
                    option.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false
                    };
                });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
