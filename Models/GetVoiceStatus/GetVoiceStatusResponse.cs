namespace PishgamApi.Models.GetVoiceStatus;

public class GetVoiceStatusResponse
{
    public ApiStatusCode StatusCode { get; set; }
    public VoiceStatus VoiceStatus { get; set; }
}