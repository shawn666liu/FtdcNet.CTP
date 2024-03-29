## FtdcNet.CTP

.Net wrapper for ftdc2c_ctp. Support x86/x64/AnyCPU.

## License

Licensed under the [MIT License](http://www.mit-license.org/)

## Version
git branche  => CTP version  
* v6.5.1 &nbsp;  => CTP version is V6.5.1 &nbsp; (20200908) 
* v6.3.19 => CTP version is V6.3.19 (20200106) 
* v6.3.15 => CTP version is V6.3.15 (20190220) 

## Build from source   
  you need to specify --recursive to clone submodules as well.  
  git clone --recursive https://github.com/shawn666liu/FtdcNet.CTP.git   

  switch to other branch (other CTP version)  
  for example, switch to v6.3.15  
  git checkout v6.3.15  
  cd ftdc2c_ctp  
  git checkout v6.3.15    

## Use NuGet (recommend)    
  https://www.nuget.org/packages/FtdcNet.CTP  

版本对应
* FtdcNet.CTP.1.3.0.nupkg  => CTP v6.5.1
* FtdcNet.CTP.1.2.0.nupkg  => CTP v6.3.19
* FtdcNet.CTP.1.1.0.nupkg  => CTP v6.3.15

按所需CTP版本安装  
* Install-Package FtdcNet.CTP -Version 1.3.0
* Install-Package FtdcNet.CTP -Version 1.2.0
* Install-Package FtdcNet.CTP -Version 1.1.0

使用

* NetCore及Net5项目，使用NuGet Manager添加Package之后，会自动拷贝所需文件到可执行目录下的runtimes目录
* Net Framework项目，如果platform是AnyCPU或者是VS2013项目，需要手动拷贝runtimes目录到可执行文件的输出目录，  
  添加方法一： vs项目添加包后，会在C:\\Users\\????\\.nuget\\packages\\ftdcnet.ctp 下保留ftdcnet.ctp.???.nupkg  
  添加方法二： 从https://www.nuget.org/packages/FtdcNet.CTP 页面, 选中合适版本, 点击右边"Download package"下载nupkg包  
  使用7zip或者winzip打开下载后的包，比如 ftdcnet.ctp.1.2.0.nupkg 文件，提取runtimes目录到你的exe所在目录  
* Net Framework项目，如果是VS2019，可以不使用AnyCPU，platform选择x86/x64时，VS会自动复制相应的dll到exe目录，而无需runtimes目录
  

## ChangeLog
  See [ChangeLog.md](ChangeLog.md) 