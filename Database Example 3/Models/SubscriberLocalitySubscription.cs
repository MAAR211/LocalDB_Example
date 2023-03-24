using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class SubscriberLocalitySubscription
{
    public long SubscriberLocalitySubscriptionId { get; set; }

    public long SubscriberId { get; set; }

    public int LocalityId { get; set; }
}
