CREATE TABLE [Subscription] (
[Id] INTEGER  PRIMARY KEY NOT NULL,
[Type] NVARCHAR(200)  NULL,
[AccessKey] NVARCHAR(20)  NOT NULL,
[SecretKey] NVARCHAR(20)  NOT NULL,
[State] NVARCHAR(100)  NOT NULL,
[CreatedDate] DATE  NOT NULL
);

CREATE TABLE [SubscriptionItem] (
[Id] INTEGER  PRIMARY KEY NOT NULL,
[SubscriptionId] INTEGER  NOT NULL,
[ApplicationId] INTEGER  NOT NULL,
FOREIGN KEY(SubscriptionId) REFERENCES Subscription(Id)
);