 discord = New DiscordSocketClient(New DiscordSocketConfig With {
                            .WebSocketProvider = Net.Providers.WS4Net.WS4NetProvider.Instance,
                            .UdpSocketProvider = Net.Providers.UDPClient.UDPClientProvider.Instance,
                            .MessageCacheSize = 50
        })

        AddHandler discord.MessageReceived, AddressOf onMsg


        Await discord.SetGameAsync(".help For Command`s")
        Await discord.LoginAsync(TokenType.Bot, "NDM2OTM1OTIyMjM2NTIyNDk4.Dbuv3A.7CQI4NULoEStkGixOZd1Xak2DcQ")
        Await discord.StartAsync()
