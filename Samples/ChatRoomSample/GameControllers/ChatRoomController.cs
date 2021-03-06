﻿using Microsoft.Extensions.Logging;
using SKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SKit.Common;

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

        [AllowAnonymous]
        public void Call_Chat(string msg)
        {
            string str;
            //if (s.IsAuthorized)
            //{
            //    str = $"{s.UserName}: {msg}";
            //}
            //else
            //{
            //    str = $"{s.Id}: {msg}";
            //}
            str = msg;
            _server.BroadcastAllSessionAsync(str);
            _logger.LogDebug(str);
        }
        
        public override void OnLeave(ClientCloseReason reason)
        {
            _logger.LogDebug($"{CurrentSession.Id}: LEAVE, reason: {reason}");
        }
    }
}
