﻿///Cited from http://blog.csdn.net/zhujunxxxxx/article/details/44258719

using System;

namespace Common.Core.TcpServer
{
    public sealed class AsyncEventArgs : EventArgs
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        public string _msg;

        /// <summary>
        /// 客户端状态封装类
        /// </summary>
        public TCPClientState _state;

        /// <summary>
        /// 是否已经处理过了
        /// </summary>
        public bool IsHandled { get; set; }

        public AsyncEventArgs(string msg)
        {
            this._msg = msg;
            IsHandled = false;
        }
        public AsyncEventArgs(TCPClientState state)
        {
            this._state = state;
            IsHandled = false;
        }
        public AsyncEventArgs(string msg, TCPClientState state)
        {
            this._msg = msg;
            this._state = state;
            IsHandled = false;
        }
    }
}
