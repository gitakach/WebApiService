using System.ComponentModel;

namespace PishgamApi.Models.SendVoiceOtp;

public class SendVoiceOtpResponse
{
    public ApiStatusCode StatusCode { get; set; }
    [Description("کد ارسال سریع میباشد")]
    public int QuickSendId { get; set; }
    [Description("کد تولید شده میباشد")]
    public string GeneratedCode { get; set; } = string.Empty;
    [Description("کد خطاها")]
    public SendVoiceOtpErrors? SendVoiceOtpErrors { get; set; }
    [Description("کد خطاهای احراز")]
    public VoiceAuthorizationErrors? SendVoiceOtpAuthorizationErrors { get; set; }
}