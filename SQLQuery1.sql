CREATE TABLE [Role](
id INT IDENTITY(1,1) PRIMARY KEY,
[name] VARCHAR(50) NOT NULL
)

CREATE TABLE [User](
id INT IDENTITY(1,1) PRIMARY KEY,
Roleid INT NOT NULL,
FOREIGN KEY (Roleid) REFERENCES [Role](id),
[Username] VARCHAR(50) NOT NULL,
[Email] VARCHAR(50) NOT NULL,
[Gender] VARCHAR(50) NOT NULL,
[Password] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Header] (
    [id]         INT  IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT  NOT NULL,
    [Staffid]    INT  NOT NULL,
    [Date]       DATE NULL,
    [OrderId]    INT  NULL,
    [Status] VARCHAR(255) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[User] ([id])
);

CREATE TABLE Meat(
id INT IDENTITY(1,1) PRIMARY KEY,
[name] VARCHAR(50) NOT NULL
)

CREATE TABLE Ramen(
id INT IDENTITY(1,1) PRIMARY KEY,
Meatid INT NOT NULL,
FOREIGN KEY (Meatid) REFERENCES [Meat](id),
[Name] VARCHAR(50) NOT NULL,
Borth VARCHAR(50) NOT NULL,
Price VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Cart] (
    [CartId]   INT IDENTITY (1, 1) NOT NULL,
    [UserId]   INT NOT NULL,
    [RamenId]  INT NOT NULL,
    [Quantity] INT NOT NULL,
    [OrderId]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([CartId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([id]),
    FOREIGN KEY ([RamenId]) REFERENCES [dbo].[Ramen] ([id])
);

CREATE TABLE [dbo].[Detail] (
    [id] INT PRIMARY KEY IDENTITY(1,1),
    [Headerid] INT NOT NULL,
    [Ramenid]  INT NOT NULL,
    [Quantity] INT NOT NULL,
    FOREIGN KEY ([Headerid]) REFERENCES [dbo].[Header] ([id]),
    FOREIGN KEY ([Ramenid]) REFERENCES [dbo].[Ramen] ([id]),
);

CREATE TABLE [dbo].[Order] (
    [OrderId]     INT IDENTITY (1, 1) NOT NULL,
    [OrderNumber] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

INSERT INTO [Role]( [name]) VALUES ('member'), ('admin'), ('staff')

INSERT INTO [User](Roleid, Username, Email, Gender, [Password]) 
VALUES ('1','member','member@gmail.com','Male','aaa'),
 ('2','admin','admin@gmail.com','Male','aaa'),  
 ('3','staff','staff@gmail.com','Male','aaa')


INSERT INTO [Order](OrderNumber) VALUES ('1')

INSERT INTO [Meat]( [name]) VALUES ('chicken'), ('beef'), ('pork')