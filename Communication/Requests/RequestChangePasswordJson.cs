namespace Rkst03ASP1.Communication.Requests;

public class RequestChangePasswordJson {
    public string OldPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
}