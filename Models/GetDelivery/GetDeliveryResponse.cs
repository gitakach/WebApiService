namespace PishgamApi.Models.GetDelivery;

public class GetDeliveryResponse
{
    /// <summary>
    /// کد وضعیت
    /// </summary>
    public ApiStatusCode StatusCode { get; set; }
    /// <summary>
    /// آرایه ای از وضعیت دریافت
    /// </summary>
    public List<DeliveryStatus> DeliveryStatus { get; set; } = null!;
}