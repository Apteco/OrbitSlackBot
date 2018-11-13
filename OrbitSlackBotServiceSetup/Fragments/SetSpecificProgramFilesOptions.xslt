<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:wix="http://schemas.microsoft.com/wix/2006/wi"
                exclude-result-prefixes="wix  xsl"
>
  <xsl:output method="xml" indent="yes"/>
  <xsl:strip-space elements="*"/>

  <xsl:template match="@*|node()">
    <xsl:copy>
     <xsl:apply-templates select="@*|node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="wix:Component[wix:File/@Source = '$(var.ProgramFilesSource)\OrbitSlackBot.exe']">
    <Component Id="{@Id}" Guid="{@Guid}" xmlns="http://schemas.microsoft.com/wix/2006/wi">
      <xsl:apply-templates />
      <ServiceInstall
        Id="svcInstAptecoOrbitSlackBot"
        Type="ownProcess"
        Vital="yes"
        Name="AptecoOrbitSlackBot"
        DisplayName="Apteco Orbit Slack Bot"
        Description="Service for the Apteco Orbit Slack Bot"
        Start="auto"
        Account="LocalSystem"
        ErrorControl="normal"
        Interactive="no"
        />
      <ServiceControl 
        Id="svcStartOrbitSlackBotService" 
        Start="install" 
        Stop="both"
        Remove="uninstall" 
        Name="AptecoOrbitSlackBot" 
        Wait="yes" />
    </Component>
  </xsl:template>

  <xsl:template match="wix:Component[wix:File/@Source = '$(var.ProgramFilesSource)\OrbitSlackBot.exe.config']">
    <Component Id="{@Id}" Guid="{@Guid}" Permanent="yes" NeverOverwrite="yes" xmlns="http://schemas.microsoft.com/wix/2006/wi">
      <File Id="{wix:File/@Id}" KeyPath="{wix:File/@KeyPath}" Source="{wix:File/@Source}" />
    </Component>
  </xsl:template>

</xsl:stylesheet>