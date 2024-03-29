USE [jxc]
GO
/****** Object:  Table [dbo].[t_bm]    Script Date: 12/01/2017 15:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_bm](
	[bh] [char](2) NOT NULL,
	[mc] [varchar](10) NOT NULL,
	[fzrbh] [char](4) NOT NULL,
 CONSTRAINT [PK_t_bm] PRIMARY KEY CLUSTERED 
(
	[bh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_jhd]    Script Date: 12/01/2017 15:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_jhd](
	[jhrq] [datetime] NOT NULL,
	[xh] [smallint] NOT NULL,
	[gysbh] [varchar](10) NOT NULL,
	[jhrbh] [char](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[jhrq] ASC,
	[xh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[p_insjhd]    Script Date: 12/01/2017 15:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_insjhd]
@gysbh varchar(10),@jhrbh char(4)
as declare @jhrq datetime,@xh int
set @jhrq = CONVERT(datetime, CONVERT(char(10),getdate(),101))
set @xh = (select MAX(xh) from t_jhd where jhrq=@jhrq)
if @xh is null set @xh=0
set @xh = @xh+1
insert into t_jhd(jhrq,xh,gysbh,jhrbh)values(@jhrq,@xh,@gysbh,@jhrbh)
GO
/****** Object:  Table [dbo].[t_jhmx]    Script Date: 12/01/2017 15:10:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_jhmx](
	[jhrq] [datetime] NOT NULL,
	[xh] [smallint] NOT NULL,
	[spbh] [varchar](10) NOT NULL,
	[sl] [smallint] NOT NULL,
	[dj] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[jhrq] ASC,
	[xh] ASC,
	[spbh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_jhdje]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_jhdje] as
select jhrq,xh,sum(sl*dj) as je from t_jhmx group by jhrq,xh
GO
/****** Object:  Table [dbo].[t_zg]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_zg](
	[bh] [char](4) NOT NULL,
	[xm] [varchar](8) NOT NULL,
	[xb] [char](2) NULL,
	[csrq] [datetime] NULL,
	[zybh] [char](4) NULL,
	[hf] [bit] NULL,
	[bmbh] [char](2) NULL,
	[kl] [varchar](10) NULL,
	[qx] [tinyint] NOT NULL,
 CONSTRAINT [PK_t_zg] PRIMARY KEY CLUSTERED 
(
	[bh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_zy]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_zy](
	[bh] [char](4) NOT NULL,
	[mc] [varchar](10) NOT NULL,
 CONSTRAINT [PK_t_zy] PRIMARY KEY CLUSTERED 
(
	[bh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_cs]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_cs](
	[mc] [varchar](10) NOT NULL,
	[nr] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[mc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[BuildLeadingZeroStr]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[BuildLeadingZeroStr](@Num int,@Length int = 4)
returns varchar(6) as
begin
	return right(convert(varchar(7),1000000 + @Num),@Length)
end
GO
/****** Object:  Table [dbo].[t_xsmx]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_xsmx](
	[xsrq] [datetime] NOT NULL,
	[xh] [smallint] NOT NULL,
	[spbh] [varchar](10) NOT NULL,
	[sl] [smallint] NOT NULL,
	[dj] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[xsrq] ASC,
	[xh] ASC,
	[spbh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_sp]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_sp](
	[bh] [varchar](10) NOT NULL,
	[mc] [varchar](20) NOT NULL,
	[xh] [varchar](16) NOT NULL,
	[gg] [varchar](16) NULL,
	[dw] [varchar](2) NOT NULL,
	[kcxx] [smallint] NULL,
	[kcsx] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[bh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_xsd]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_xsd](
	[xsrq] [datetime] NOT NULL,
	[xh] [smallint] NOT NULL,
	[khbh] [varchar](10) NOT NULL,
	[xsrbh] [char](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[xsrq] ASC,
	[xh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_khgys]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_khgys](
	[bh] [varchar](10) NOT NULL,
	[mc] [varchar](20) NOT NULL,
	[lxr] [varchar](8) NOT NULL,
	[lxdh] [varchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[bh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_kc]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_kc](
	[spbh] [varchar](10) NOT NULL,
	[sl] [smallint] NOT NULL,
	[dj] [decimal](12, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[spbh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[p_rk]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[p_rk]
@jhrqtmp datetime,@xhtmp int as
declare @spbh varchar(10),@sl smallint,@dj decimal(12,2)
declare jhmxtmp cursor for
select spbh,sl,dj from t_jhmx where jhrq=@jhrqtmp and xh=@xhtmp order by spbh
open jhmxtmp
begin transaction
fetch next from jhmxtmp into @spbh,@sl,@dj
declare @error_var int,@rowcount_var int
while @@FETCH_STATUS=0
begin
update t_kc set dj=(sl*dj+@sl*@dj)/(sl+@sl),sl=sl+@sl where spbh = @spbh
select @error_var=@@ERROR,@rowcount_var=@@ROWCOUNT
if @error_var<>0
begin
raiserror('更新库存错误',16,1)
goto error_handler
end
if @rowcount_var=0
begin
insert into t_kc(spbh,sl,dj)values(@spbh,@sl,@dj)
if @@error<>0
begin
raiserror('插入库存商品错误',16,1)
goto error_handler
end
end
fetch next from jhmxtmp into @spbh,@sl,@dj
end
close jhmxtmp
deallocate jhmxtmp
commit transaction
return 0
error_handler:
close jhmxtmp
deallocate jhmxtmp
rollback transaction
return 1
GO
/****** Object:  UserDefinedFunction [dbo].[BuildBhFromDateAndXh]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[BuildBhFromDateAndXh](@Date datetime,@Num int,@Length int=4)
returns varchar(14) as
begin
	declare @s char(10)
	set @s = convert(char(10),@Date,102)
	return left(@s,4)+substring(@s,6,2)+right(@s,2)+dbo.BuildLeadingZeroStr(@Num,@Length)
end
GO
/****** Object:  View [dbo].[v_jhd]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_jhd] as
select a.jhrq,a.xh,a.gysbh,b.mc as gysmc,a.jhrbh,c.xm as jhrxm,d.je,bh=dbo.BuildBhFromDateAndXh(a.jhrq,a.xh,default)
from t_jhd a
	left join t_khgys b on a.gysbh = b.bh
	left join t_zg c on a.jhrbh = c.bh
	left join v_jhdje d on a.jhrq = d.jhrq and a.xh = d.xh
GO
/****** Object:  View [dbo].[v_sp]    Script Date: 12/01/2017 15:10:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[v_sp] as
select a.*,b.sl,b.dj from t_sp a left outer join t_kc b on a.bh=b.spbh
GO
/****** Object:  Default [DF_t_zg_kl]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_zg] ADD  CONSTRAINT [DF_t_zg_kl]  DEFAULT ((0)) FOR [kl]
GO
/****** Object:  Default [DF_t_zg_qx]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_zg] ADD  CONSTRAINT [DF_t_zg_qx]  DEFAULT ((2)) FOR [qx]
GO
/****** Object:  Check [CK_t_jhmx_dj]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_jhmx]  WITH CHECK ADD  CONSTRAINT [CK_t_jhmx_dj] CHECK  (([dj]>(0)))
GO
ALTER TABLE [dbo].[t_jhmx] CHECK CONSTRAINT [CK_t_jhmx_dj]
GO
/****** Object:  Check [CK_t_jhmx_sl]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_jhmx]  WITH CHECK ADD  CONSTRAINT [CK_t_jhmx_sl] CHECK  (([sl]>(0)))
GO
ALTER TABLE [dbo].[t_jhmx] CHECK CONSTRAINT [CK_t_jhmx_sl]
GO
/****** Object:  Check [CK_t_xsmx_dj]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_xsmx]  WITH CHECK ADD  CONSTRAINT [CK_t_xsmx_dj] CHECK  (([dj]>(0)))
GO
ALTER TABLE [dbo].[t_xsmx] CHECK CONSTRAINT [CK_t_xsmx_dj]
GO
/****** Object:  Check [CK_t_xsmx_sl]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_xsmx]  WITH CHECK ADD  CONSTRAINT [CK_t_xsmx_sl] CHECK  (([sl]>(0)))
GO
ALTER TABLE [dbo].[t_xsmx] CHECK CONSTRAINT [CK_t_xsmx_sl]
GO
/****** Object:  Check [CK_t_sp_kcx]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_sp]  WITH CHECK ADD  CONSTRAINT [CK_t_sp_kcx] CHECK  (([kcxx]>=(0) AND [kcxx]<[kcsx]))
GO
ALTER TABLE [dbo].[t_sp] CHECK CONSTRAINT [CK_t_sp_kcx]
GO
/****** Object:  Check [CK_t_kc_dj]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_kc]  WITH CHECK ADD  CONSTRAINT [CK_t_kc_dj] CHECK  (([dj]>(0)))
GO
ALTER TABLE [dbo].[t_kc] CHECK CONSTRAINT [CK_t_kc_dj]
GO
/****** Object:  Check [CK_t_kc_sl]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_kc]  WITH CHECK ADD  CONSTRAINT [CK_t_kc_sl] CHECK  (([sl]>(0)))
GO
ALTER TABLE [dbo].[t_kc] CHECK CONSTRAINT [CK_t_kc_sl]
GO
/****** Object:  ForeignKey [FK_t_bm_t_zg]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_bm]  WITH CHECK ADD  CONSTRAINT [FK_t_bm_t_zg] FOREIGN KEY([fzrbh])
REFERENCES [dbo].[t_zg] ([bh])
GO
ALTER TABLE [dbo].[t_bm] CHECK CONSTRAINT [FK_t_bm_t_zg]
GO
/****** Object:  ForeignKey [FK__t_jhd__gysbh__0F975522]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_jhd]  WITH CHECK ADD FOREIGN KEY([gysbh])
REFERENCES [dbo].[t_khgys] ([bh])
GO
/****** Object:  ForeignKey [FK__t_jhd__jhrbh__108B795B]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_jhd]  WITH CHECK ADD FOREIGN KEY([jhrbh])
REFERENCES [dbo].[t_zg] ([bh])
GO
/****** Object:  ForeignKey [FK__t_jhmx__1BFD2C07]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_jhmx]  WITH CHECK ADD FOREIGN KEY([jhrq], [xh])
REFERENCES [dbo].[t_jhd] ([jhrq], [xh])
GO
/****** Object:  ForeignKey [FK__t_jhmx__spbh__1CF15040]    Script Date: 12/01/2017 15:10:09 ******/
ALTER TABLE [dbo].[t_jhmx]  WITH CHECK ADD FOREIGN KEY([spbh])
REFERENCES [dbo].[t_sp] ([bh])
GO
/****** Object:  ForeignKey [FK__t_zg__zybh__060DEAE8]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_zg]  WITH CHECK ADD FOREIGN KEY([zybh])
REFERENCES [dbo].[t_zy] ([bh])
GO
/****** Object:  ForeignKey [Fk_t_zg_t_bm]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_zg]  WITH CHECK ADD  CONSTRAINT [Fk_t_zg_t_bm] FOREIGN KEY([bmbh])
REFERENCES [dbo].[t_bm] ([bh])
GO
ALTER TABLE [dbo].[t_zg] CHECK CONSTRAINT [Fk_t_zg_t_bm]
GO
/****** Object:  ForeignKey [FK__t_xsmx__29572725]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_xsmx]  WITH CHECK ADD FOREIGN KEY([xsrq], [xh])
REFERENCES [dbo].[t_xsd] ([xsrq], [xh])
GO
/****** Object:  ForeignKey [FK__t_xsmx__spbh__2A4B4B5E]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_xsmx]  WITH CHECK ADD FOREIGN KEY([spbh])
REFERENCES [dbo].[t_sp] ([bh])
GO
/****** Object:  ForeignKey [FK__t_xsd__khbh__21B6055D]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_xsd]  WITH CHECK ADD FOREIGN KEY([khbh])
REFERENCES [dbo].[t_khgys] ([bh])
GO
/****** Object:  ForeignKey [FK__t_xsd__xsrbh__22AA2996]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_xsd]  WITH CHECK ADD FOREIGN KEY([xsrbh])
REFERENCES [dbo].[t_zg] ([bh])
GO
/****** Object:  ForeignKey [FK__t_kc__spbh__30F848ED]    Script Date: 12/01/2017 15:10:10 ******/
ALTER TABLE [dbo].[t_kc]  WITH CHECK ADD FOREIGN KEY([spbh])
REFERENCES [dbo].[t_sp] ([bh])
GO
