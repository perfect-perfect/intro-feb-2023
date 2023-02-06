﻿using Finger;
using Marten;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "host=localhost;database=status_dev;password=TokyoJoe138!;username=postgres;port=5432";

builder.Services.AddMarten(options =>
{
    options.Connection(connectionString);
    if (builder.Environment.IsDevelopment())
    {
        options.AutoCreateSchemaObjects = Weasel.Core.AutoCreate.All;
    }
});

var app = builder.Build();

// doc comes from Marten
app.MapGet("/status", async (IDocumentSession doc) =>
{
    var results = await doc.Query<StatusMessage>()
    .OrderByDescending(m => m.When)
    .FirstOrDefaultAsync();
    if (results != null)
    {
        return Results.Ok(results);
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapPost("/status", async (StatusRequest req, IDocumentSession doc) =>
{
    var messageToSave = new StatusMessage(Guid.NewGuid(), req.Message, DateTimeOffset.Now);
    doc.Store<StatusMessage>(messageToSave);
    await doc.SaveChangesAsync();
    return messageToSave;
});

app.Run(); // Blocking Call

public record StatusRequest(string Message);