﻿using Microsoft.Extensions.Logging;
using SKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomSample.GameControllers
{
    public class ChatRoomController: GameController
    {
        private GameServer _server;
        private ILogger<ChatRoomController> _logger;
        public ChatRoomController(GameServer server, ILogger<ChatRoomController> logger)
        {
            _server = server;
            _logger = logger;
        }

        public void Chat(GameSession s, string msg)
        {
            string str;
            if (s.IsAuthorized)
            {
                str = $"{s.UserName}: {msg}";
            }
            else
            {
                str = $"{s.Id}: {msg}";
            }
            _server.BroadcastAllSessionAsync(str);
            _logger.LogDebug(str);
        }
        
        public override void OnLeave(GameSession s, ClientCloseReason reason)
        {
            _logger.LogDebug($"{s.Id}: LEAVE, reason: {reason}");
        }
    }
}