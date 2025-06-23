namespace QRAdmit_Domain.Enums
{
    enum GeneralEnums
    {

    }

    public enum AccountType
    {
        Organization = 1,
        Individual = 2
    }

     public enum EventType
    {
        Virtual = 1,
        Onsite,
        Hybrid
    }

    public enum ScanStatus
    {
        Valid = 1,
        Expired, 
        Duplicate, 
        Invalid
    }

    public enum TicketTypeName
    {
        Regular = 1,
        VIP, 
        VVIP, 
        Bronze,
        Silver, 
        Gold,
        Platinum,
        Diamond,
        Executive
    }


}
