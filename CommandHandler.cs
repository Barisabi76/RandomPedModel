using System;
using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Enums;
using PedHandlerClass;


[Command("randomped")]
public static void ChangePlayerModel(IPlayer player)
{
    try
    {
        if (player == null || !player.Exists) return;

        PedHandler.RandomPedModel(player);
        return;

    }
    catch (Exception e)
    {
        Console.WriteLine($"ChangePlayerModel: {e.StackTrace}");
    }
}