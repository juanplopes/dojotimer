# DojoTimer 

Download latest version at:

[juanlopes.net/dojotimer](http://juanlopes.net/dojotimer)

This DojoTimer is as simple as it gets. It becomes red when tests aren't passing.

![Green DojoTimer](https://github.com/juanplopes/dojotimer/raw/master/doc/green.png) 
![Red DojoTimer](https://github.com/juanplopes/dojotimer/raw/master/doc/red.png) 
![Red DojoTimer Small](https://github.com/juanplopes/dojotimer/raw/master/doc/redsmall.png)

## Developing

Clone. Build.

### Build on Windows

Run ```build.cmd```

### Build on Linux

Run ```xbuild build.xml```

You probably will have to install the most complete Mono version to do that. 
Or at least the development packages and gtksharp-2.0.

### Build on Docker

If you have Docker installed, you can skip installing the Mono development tools
and build a Linux binary using:

```
$ docker run --rm -it -v `pwd`:/src mono:4.4 bash
# cd /src
# xbuild build.xml
```

You will still need `mono` and `gtk-sharp2` to run the binary in the host
system. On a Fedora workstation, install those packages by running:

```
sudo dnf install mono gtk-sharp2
```
