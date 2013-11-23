var URL = Class.create({
    init: function (title, url) {
        this.title = title;
        this.url = url;
    }
});
var Folder = Class.create({
    init: function (title, setOfUrls) {
        this.title = title;
        this.setOfUrls = setOfUrls;
    }
});
var FavoriteSiteBar = Class.create({
    init: function (setOfUrls, setOfFolders) {
        this.setOfUrls = setOfUrls;
        this.setOfFolders = setOfFolders;
        this.container = document.createElement("div");
        this.count = 0;
    },
    display: function () {
        this.container.id = "container";
        document.body.appendChild(this.container);
        if (this.count == 0) {
            this.displaySetOfUrls();
            this.displaySetOfFolders();
            this.count += 1;
        }
    },
    displaySetOfUrls: function () {
        var setOfUrls = this.setOfUrls;
        for (var i = 0; i < setOfUrls.length; i++) {
            var url = document.createElement("a");
            url.innerHTML = setOfUrls[i].title;
            url.href = setOfUrls[i].url;
            url.target = "_blank";
            this.container.appendChild(url);
        }
    },
    displaySetOfFolders: function () {
        var folders = this.setOfFolders;
        for (var i = 0; i < folders.length; i++) {
            var paragraph = document.createElement("p");
            paragraph.id = folders[i].title;
            paragraph.innerHTML = folders[i].title;
            paragraph.className = "container-folder";
            if (paragraph.childElementCount == 0) {
                var index;
                for (var k = 0; k < folders.length; k++) {
                    if (paragraph.id == folders[k].title) {
                        index = k;
                        break;
                    }
                }
                if (folders[index].setOfUrls) {
                    var wrapper = document.createElement("div");
                    for (var j = 0; j < folders[index].setOfUrls.length; j++) {
                        var url = document.createElement("a");
                        url.href = folders[index].setOfUrls[j].url;
                        url.innerHTML = folders[index].setOfUrls[j].title;
                        url.target = "_blank";
                        wrapper.appendChild(url);
                    }
                    wrapper.style.display = "none";
                    wrapper.style.position = "absolute";
                    paragraph.appendChild(wrapper);
                }
            }
            paragraph.onclick = function (ev) {
                if (ev.target.hasChildNodes) {
                    for (var i = 1; i < ev.target.childNodes.length; i++) {
                        var childElement = ev.target.childNodes[i];
                        if (childElement.style.display == "block") {
                            childElement.style.display = "none"
                        }
                        else {
                            childElement.style.display = "block";
                        }
                    }
                }
            }
            this.container.appendChild(paragraph);
        }
    }
});