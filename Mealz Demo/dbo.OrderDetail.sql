CREATE TABLE [dbo].[OrderDetail] (
    [order_num]   INT         NOT NULL,
    [stock_id]    VARCHAR (4) NULL,
    [quantity]    INT         NULL,
    [price]       INT         NULL,
    [student_num] TEXT        NOT NULL,
    [Order_Prep] BIT NULL, 
    [Order_finished] BIT NULL, 
    PRIMARY KEY CLUSTERED ([order_num] ASC)
);

