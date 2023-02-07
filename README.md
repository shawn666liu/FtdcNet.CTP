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

�汾��Ӧ
* FtdcNet.CTP.1.3.0.nupkg  => CTP v6.5.1
* FtdcNet.CTP.1.2.0.nupkg  => CTP v6.3.19
* FtdcNet.CTP.1.1.0.nupkg  => CTP v6.3.15

������CTP�汾��װ  
* Install-Package FtdcNet.CTP -Version 1.3.0
* Install-Package FtdcNet.CTP -Version 1.2.0
* Install-Package FtdcNet.CTP -Version 1.1.0

ʹ��

* NetCore��Net5��Ŀ��ʹ��NuGet Manager���Package֮�󣬻��Զ����������ļ�����ִ��Ŀ¼�µ�runtimesĿ¼
* Net Framework��Ŀ�����platform��AnyCPU������VS2013��Ŀ����Ҫ�ֶ�����runtimesĿ¼����ִ���ļ������Ŀ¼��  
  ��ӷ���һ�� vs��Ŀ��Ӱ��󣬻���C:\\Users\\????\\.nuget\\packages\\ftdcnet.ctp �±���ftdcnet.ctp.???.nupkg  
  ��ӷ������� ��https://www.nuget.org/packages/FtdcNet.CTP ҳ��, ѡ�к��ʰ汾, ����ұ�"Download package"����nupkg��  
  ʹ��7zip����winzip�����غ�İ������� ftdcnet.ctp.1.2.0.nupkg �ļ�����ȡruntimesĿ¼�����exe����Ŀ¼  
* Net Framework��Ŀ�������VS2019�����Բ�ʹ��AnyCPU��platformѡ��x86/x64ʱ��VS���Զ�������Ӧ��dll��exeĿ¼��������runtimesĿ¼
  

## ChangeLog
  See [ChangeLog.md](ChangeLog.md) 