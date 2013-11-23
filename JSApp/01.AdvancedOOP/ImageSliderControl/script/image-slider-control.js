var imageSliderControl = (function () {
    var Image = {
        init: function (title, thumbnailUrl, largeUrl) {
            this.title = title;
            this.thumbnailUrl = thumbnailUrl;
            this.largeUrl = largeUrl;
        }
    };

    var Button = {
        init: function (id, title) {
            this.id = id;
            this.title = title;
        }
    };

    var ImageSlider = {
        init: function (selectorImages, selectorPreview) {
            this.wrapper = document.getElementById(selectorImages);
            this.images = [];
            this.preview = document.getElementById(selectorPreview);
            this.currentImageNumber;
        },

        addImage: function (title, thumbnailUrl, largeUrl) {
            var img = Object.create(Image);
            img.init(title, thumbnailUrl, largeUrl);
            this.images.push(img);
        },

        renderImages: function () {
            var i = 0;
            var fragment = document.createDocumentFragment();
            for (i = 0; i < this.images.length; i++) {
                var img = document.createElement("img");
                img.id = i;
                img.setAttribute("title", this.images[i].title);
                img.setAttribute("src", this.images[i].thumbnailUrl);
                img.setAttribute("alt", this.images[i].title);
                img.style.width = "160px";
                img.style.height = "120px";

                fragment.appendChild(img);
            }

            this.wrapper.appendChild(fragment);
            var that = this;
            this.addHandler(this.wrapper, "click", function (ev) {
                if (!ev) {
                    ev = window.event;
                }
                if (ev.stopPropagation) {
                    ev.stopPropagation();
                }
                if (ev.preventDefault) {
                    ev.preventDefault();
                }

                var target = ev.target || ev.srcElement;
                if (target instanceof HTMLImageElement) {
                    that.currentImageNumber = target.id;
                    that.showLargeImg(that.currentImageNumber);
                }
            });
        },

        showLargeImg: function (id) {
            var img = document.createElement("img");
            img.id = "preview-image";
            img.setAttribute("title", this.images[id].title);
            img.setAttribute("src", this.images[id].largeUrl);
            img.setAttribute("alt", this.images[id].title);
            img.style.width = "640px";
            img.style.height = "480px";
            img.style.display = "block";
            var oldImage = document.getElementById("preview-image");
            if (oldImage) {
                this.preview.removeChild(oldImage);
            }
            else {
                this.addButton("left");
                this.addButton("right");
                this.attachPreviewEvents();
            }
            this.preview.appendChild(img);
        },

        attachPreviewEvents: function () {
            var that = this;
            this.addHandler(this.preview, "click", function (ev) {
                if (!ev) {
                    ev = window.event;
                }
                if (ev.stopPropagation) {
                    ev.stopPropagation();
                }
                if (ev.preventDefault) {
                    ev.preventDefault();
                }

                var target = ev.target || ev.srcElement;
                if (target instanceof HTMLButtonElement) {
                    if (target.id == "leftButton" && that.currentImageNumber != 0) {
                        that.currentImageNumber--;
                        that.showLargeImg(that.currentImageNumber);
                    }
                    else if (target.id == "leftButton" && that.currentImageNumber == 0) {
                        that.currentImageNumber = that.images.length - 1;
                        that.showLargeImg(that.currentImageNumber);
                    }

                    if (target.id == "rightButton" && that.currentImageNumber != that.images.length - 1) {
                        that.currentImageNumber++;
                        that.showLargeImg(that.currentImageNumber);
                    }
                    else if (target.id == "rightButton" && that.currentImageNumber == that.images.length - 1) {
                        that.currentImageNumber = 0;
                        that.showLargeImg(that.currentImageNumber);
                    }
                }
            });
        },

        addButton: function (side) {
            var button = Object.create(Button);
            var btn = document.createElement("button");
            btn.className = "button";
                        
            if (side === "left") {
                button.init("leftButton", side);
                btn.innerHTML = "<img src=img/left.png height=25px>";
            }
            if (side === "right") {
                button.init("rightButton", side);
                btn.innerHTML = "<img src=img/right.png height=25px>";
            }

            btn.id = button.id;
            this.preview.appendChild(btn);
        },

        addHandler: function (element, eventType, eventHandler) {
            if (element.addEventListener) {
                element.addEventListener(eventType, eventHandler, false);
            } else if (document.attachEvent) {
                element.attachEvent("on" + eventType, eventHandler);
            }
            else {
                element["on" + eventType] = eventHandler;
            }
        }
    };

    createImageSlider = function () {
        return Object.create(ImageSlider);
    };

    return {
        createImageSlider: createImageSlider
    };
})();