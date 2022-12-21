﻿namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит перечисление статусов заказов.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
