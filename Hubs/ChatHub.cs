using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Hubs
{
    /// <summary>
    /// 对话集线器
    /// </summary>
    public class ChatHub : Hub
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="user"></param>
        /// <param name="messgae"></param>
        /// <returns></returns>
        public async Task SendMessage(string user, string messgae)
        {
            // 向全部连接客户端发送指定消息
            await Clients.All.SendAsync("ReceiveMessage", user, messgae);
        }
    }
}