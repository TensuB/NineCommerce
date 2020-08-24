(function($){
    // auto grow input (stackoverflow.com/questions/931207)
    $.fn.subcategoryEditorInput=function(){var t=" ",e=$(this),n=parseInt(e.css("fontSize")),i=$("<span/>").css({position:"absolute",top:-9999,left:-9999,width:"auto",fontSize:e.css("fontSize"),fontFamily:e.css("fontFamily"),fontWeight:e.css("fontWeight"),letterSpacing:e.css("letterSpacing"),whiteSpace:"nowrap"}),s=function(){if(t!==(t=e.val())){i.text(t);var s=i.width()+n;20>s&&(s=20),s!=e.width()&&e.width(s)}};return i.insertAfter(e),e.bind("keyup keydown focus",s)};

    // plugin with val as parameter for public methods
    $.fn.subcategoryEditor = function(options, val, blur){

        // helper
        function escape(subcategory) {
            return subcategory.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;").replace(/"/g, "&quot;").replace(/'/g, "&#39;");
        }

        // build options dictionary with default values
        var blur_result, o = $.extend({}, $.fn.subcategoryEditor.defaults, options), selector = this;

        // store regex and default delimiter in options for later use
        o.dregex = new RegExp('['+o.delimiter.replace('-', '\-')+']', 'g');

        // public methods
        if (typeof options == 'string') {
            // depending on selector, response may contain subcategory lists of multiple editor instances
            var response = [];
            selector.each(function(){
                // the editor is the next sibling to the hidden, original field
                var el = $(this), o = el.data('options'), ed = el.next('.subcategory-editor');
                if (options == 'getSubcategories')
                    response.push({field: el[0], editor: ed, subcategories: ed.data('subcategories')});
                else if (options == 'addsubcategory') {
                    if (o.maxSubcategories && ed.data('subcategories').length >= o.maxSubcategories) return false;
                    // insert new subcategory
                    $('<li><div class="subcategory-editor-spacer">&nbsp;'+o.delimiter[0]+'</div><div class="subcategory-editor-subcategory"></div><div class="subcategory-editor-delete"><i></i></div></li>').appendTo(ed).find('.subcategory-editor-subcategory')
                        .html('<input type="text" maxlength="'+o.maxLength+'">').addClass('active').find('input').val(val).blur();
                    if (!blur) ed.click();
                    else $('.placeholder', ed).remove();
                } else if (options == 'removesubcategory') {
                    // trigger delete on matching subcategory, then click editor to create a new subcategory
                    $('.subcategory-editor-subcategory', ed).filter(function(){return $(this).text()==val;}).closest('li').find('.subcategory-editor-delete').click();
                    if (!blur) ed.click();
                } else if (options == 'destroy') {
                    el.removeClass('subcategory-editor-hidden-src').removeData('options').off('focus.subcategory-editor').next('.subcategory-editor').remove();
                }
            });
            return options == 'getSubcategories' ? response : this;
        }

        // delete selected subcategories on backspace, delete, ctrl+x
        function delete_selected_subcategories(e){
            if (e.which == 8 || e.which == 46 || e.ctrlKey && e.which == 88) {
                try {
                    var sel = getSelection(), el = $(sel.getRangeAt(0).commonAncestorContainer);
                } catch(e){ el = 0; }
                if (el && el.hasClass('subcategory-editor')) {
                    var subcategories = [], splits = sel.toString().split(el.prev().data('options').dregex);
                    for (i=0; i<splits.length; i++){ var subcategory = $.trim(splits[i]); if (subcategory) subcategories.push(subcategory); }
                    $('.subcategory-editor-subcategory', el).each(function(){
                        if (~$.inArray($(this).text(), subcategories)) $(this).closest('li').find('.subcategory-editor-delete').click();
                    });
                    return false;
                }
            }
        }

        if (window.getSelection) $(document).off('keydown.subcategory-editor').on('keydown.subcategory-editor', delete_selected_subcategories);

        return selector.each(function(){
            var el = $(this), subcategory_list = []; // cache current subcategories

            // create editor (ed) instance
            var ed = $('<ul '+(o.clickDelete ? 'oncontextmenu="return false;" ' : '')+'class="subcategory-editor"></ul>').insertAfter(el);
            el.addClass('subcategory-editor-hidden-src') // hide original field
                .data('options', o) // set data on hidden field
                .on('focus.subcategory-editor', function(){ ed.click(); }); // simulate tabindex

            // add dummy item for min-height on empty editor
            ed.append('<li style="width:1px">&nbsp;</li>');

            // markup for new subcategory
            var new_subcategory = '<li><div class="subcategory-editor-spacer">&nbsp;'+o.delimiter[0]+'</div><div class="subcategory-editor-subcategory"></div><div class="subcategory-editor-delete"><i></i></div></li>';

            // helper: update global data
            function set_placeholder(){
                if (o.placeholder && !subcategory_list.length && !$('.deleted, .placeholder, input', ed).length)
                    ed.append('<li class="placeholder"><div>'+o.placeholder+'</div></li>');
            }

            // helper: update global data
            function update_globals(init){
                var old_subcategories = subcategory_list.toString();
                subcategory_list = $('.subcategory-editor-subcategory:not(.deleted)', ed).map(function(i, e) {
                    var val = $.trim($(this).hasClass('active') ? $(this).find('input').val() : $(e).text());
                    if (val) return val;
                }).get();
                ed.data('subcategories', subcategory_list);
                el.val(subcategory_list.join(o.delimiter[0]));
                // change callback except for plugin init
                if (!init) if (old_subcategories != subcategory_list.toString()) o.onChange(el, ed, subcategory_list);
                set_placeholder();
            }

            ed.click(function(e, closest_subcategory){
                var d, dist = 99999, loc;

                // do not create subcategory when user selects subcategories by text selection
                if (window.getSelection && getSelection() != '') return;

                if (o.maxSubcategories && ed.data('subcategories').length >= o.maxSubcategories) { ed.find('input').blur(); return false; }

                blur_result = true
                $('input:focus', ed).blur();
                if (!blur_result) return false;
                blur_result = true

                // always remove placeholder on click
                $('.placeholder', ed).remove();
                if (closest_subcategory && closest_subcategory.length)
                    loc = 'before';
                else {
                    // calculate subcategory closest to click position
                    $('.subcategory-editor-subcategory', ed).each(function(){
                        var subcategory = $(this), to = subcategory.offset(), subcategory_x = to.left, subcategory_y = to.top;
                        if (e.pageY >= subcategory_y && e.pageY <= subcategory_y+subcategory.height()) {
                            if (e.pageX < subcategory_x) loc = 'before', d = subcategory_x - e.pageX;
                            else loc = 'after', d = e.pageX - subcategory_x - subcategory.width();
                            if (d < dist) dist = d, closest_subcategory = subcategory;
                        }
                    });
                }

                if (loc == 'before') {
                    $(new_subcategory).insertBefore(closest_subcategory.closest('li')).find('.subcategory-editor-subcategory').click();
                } else if (loc == 'after')
                    $(new_subcategory).insertAfter(closest_subcategory.closest('li')).find('.subcategory-editor-subcategory').click();
                else // empty editor
                    $(new_subcategory).appendTo(ed).find('.subcategory-editor-subcategory').click();
                return false;
            });

            ed.on('click', '.subcategory-editor-delete', function(e){
                // delete icon is hidden when input is visible; place cursor near invisible delete icon on click
                if ($(this).prev().hasClass('active')) { $(this).closest('li').find('input').caret(-1); return false; }

                var li = $(this).closest('li'), subcategory = li.find('.subcategory-editor-subcategory');
                if (o.beforesubcategoryDelete(el, ed, subcategory_list, subcategory.text()) === false) return false;
                subcategory.addClass('deleted').animate({width: 0}, o.animateDelete, function(){ li.remove(); set_placeholder(); });
                update_globals();
                return false;
            });

            // delete on right mouse click or ctrl+click
            if (o.clickDelete)
                ed.on('mousedown', '.subcategory-editor-subcategory', function(e){
                    if (e.ctrlKey || e.which > 1) {
                        var li = $(this).closest('li'), subcategory = li.find('.subcategory-editor-subcategory');
                        if (o.beforesubcategoryDelete(el, ed, subcategory_list, subcategory.text()) === false) return false;
                        subcategory.addClass('deleted').animate({width: 0}, o.animateDelete, function(){ li.remove(); set_placeholder(); });
                        update_globals();
                        return false;
                    }
                });

            ed.on('click', '.subcategory-editor-subcategory', function(e){
                // delete on right click or ctrl+click -> exit
                if (o.clickDelete && (e.ctrlKey || e.which > 1)) return false;

                if (!$(this).hasClass('active')) {
                    var subcategory = $(this).text();
                    // guess cursor position in text input
                    var left_percent = Math.abs(($(this).offset().left - e.pageX)/$(this).width()), caret_pos = parseInt(subcategory.length*left_percent),
                        input = $(this).html('<input type="text" maxlength="'+o.maxLength+'" value="'+escape(subcategory)+'">').addClass('active').find('input');
                        input.data('old_subcategory', subcategory).subcategoryEditorInput().focus().caret(caret_pos);
                    if (o.autocomplete) {
                        var aco = $.extend({}, o.autocomplete);
                        // extend user provided autocomplete select method
                        var ac_select = 'select'  in aco ? o.autocomplete.select : '';
                        aco.select = function(e, ui){ if (ac_select) ac_select(e, ui); setTimeout(function(){
                            ed.trigger('click', [$('.active', ed).find('input').closest('li').next('li').find('.subcategory-editor-subcategory')]);
                        }, 20); };
                        input.autocomplete(aco);
                    }
                }
                return false;
            });

            // helper: split into multiple subcategories, e.g. after paste
            function split_cleanup(input){
                var li = input.closest('li'), sub_subcategories = input.val().replace(/ +/, ' ').split(o.dregex),
                    old_subcategory = input.data('old_subcategory'), old_subcategories = subcategory_list.slice(0), exceeded = false, cb_val; // copy subcategory_list
                for (var i=0; i<sub_subcategories.length; i++) {
                    subcategory = $.trim(sub_subcategories[i]).slice(0, o.maxLength);
                    if (o.forceLowercase) subcategory = subcategory.toLowerCase();
                    cb_val = o.beforesubcategoriesave(el, ed, old_subcategories, old_subcategory, subcategory);
                    subcategory = cb_val || subcategory;
                    if (cb_val === false || !subcategory) continue;
                    // remove duplicates
                    if (o.removeDuplicates && ~$.inArray(subcategory, old_subcategories))
                        $('.subcategory-editor-subcategory', ed).each(function(){ if ($(this).text() == subcategory) $(this).closest('li').remove(); });
                    old_subcategories.push(subcategory);
                    li.before('<li><div class="subcategory-editor-spacer">&nbsp;'+o.delimiter[0]+'</div><div class="subcategory-editor-subcategory">'+escape(subcategory)+'</div><div class="subcategory-editor-delete"><i></i></div></li>');
                    if (o.maxSubcategories && old_subcategories.length >= o.maxSubcategories) { exceeded = true; break; }
                }
                input.attr('maxlength', o.maxLength).removeData('old_subcategory').val('')
                if (exceeded) input.blur(); else input.focus();
                update_globals();
            }

            ed.on('blur', 'input', function(e){
                e.stopPropagation();
                var input = $(this), old_subcategory = input.data('old_subcategory'), subcategory = $.trim(input.val().replace(/ +/, ' ').replace(o.dregex, o.delimiter[0]));
                if (!subcategory) {
                    if (old_subcategory && o.beforesubcategoryDelete(el, ed, subcategory_list, old_subcategory) === false) {
                        input.val(old_subcategory).focus();
                        blur_result = false;
                        update_globals();
                        return;
                    }
                    try { input.closest('li').remove(); } catch(e){}
                    if (old_subcategory) update_globals();
                }
                else if (subcategory.indexOf(o.delimiter[0])>=0) { split_cleanup(input); return; }
                else if (subcategory != old_subcategory) {
                    if (o.forceLowercase) subcategory = subcategory.toLowerCase();
                    cb_val = o.beforesubcategoriesave(el, ed, subcategory_list, old_subcategory, subcategory);
                    subcategory = cb_val || subcategory;
                    if (cb_val === false) {
                        if (old_subcategory) {
                            input.val(old_subcategory).focus();
                            blur_result = false;
                            update_globals();
                            return;
                        }
                        try { input.closest('li').remove(); } catch(e){}
                        if (old_subcategory) update_globals();
                    }
                    // remove duplicates
                    else if (o.removeDuplicates)
                        $('.subcategory-editor-subcategory:not(.active)', ed).each(function(){ if ($(this).text() == subcategory) $(this).closest('li').remove(); });
                }
                input.parent().html(escape(subcategory)).removeClass('active');
                if (subcategory != old_subcategory) update_globals();
                set_placeholder();
            });

            var pasted_content;
            ed.on('paste', 'input', function(e){
                $(this).removeAttr('maxlength');
                pasted_content = $(this);
                setTimeout(function(){ split_cleanup(pasted_content); }, 30);
            });

            // keypress delimiter
            var inp;
            ed.on('keypress', 'input', function(e){
                if (o.delimiter.indexOf(String.fromCharCode(e.which))>=0) {
                    inp = $(this);
                    setTimeout(function(){ split_cleanup(inp); }, 20);
                }
            });

            ed.on('keydown', 'input', function(e){
                var $t = $(this);

                // left/up key + backspace key on empty field
                if ((e.which == 37 || !o.autocomplete && e.which == 38) && !$t.caret() || e.which == 8 && !$t.val()) {
                    var prev_subcategory = $t.closest('li').prev('li').find('.subcategory-editor-subcategory');
                    if (prev_subcategory.length) prev_subcategory.click().find('input').caret(-1);
                    else if ($t.val() && !(o.maxSubcategories && ed.data('subcategories').length >= o.maxSubcategories)) $(new_subcategory).insertBefore($t.closest('li')).find('.subcategory-editor-subcategory').click();
                    return false;
                }
                // right/down key
                else if ((e.which == 39 || !o.autocomplete && e.which == 40) && ($t.caret() == $t.val().length)) {
                    var next_subcategory = $t.closest('li').next('li').find('.subcategory-editor-subcategory');
                    if (next_subcategory.length) next_subcategory.click().find('input').caret(0);
                    else if ($t.val()) ed.click();
                    return false;
                }
                // tab key
                else if (e.which == 9) {
                    // shift+tab
                    if (e.shiftKey) {
                        var prev_subcategory = $t.closest('li').prev('li').find('.subcategory-editor-subcategory');
                        if (prev_subcategory.length) prev_subcategory.click().find('input').caret(0);
                        else if ($t.val() && !(o.maxSubcategories && ed.data('subcategories').length >= o.maxSubcategories)) $(new_subcategory).insertBefore($t.closest('li')).find('.subcategory-editor-subcategory').click();
                        // allow tabbing to previous element
                        else {
                            el.attr('disabled', 'disabled');
                            setTimeout(function(){ el.removeAttr('disabled'); }, 30);
                            return;
                        }
                        return false;
                    // tab
                    } else {
                        var next_subcategory = $t.closest('li').next('li').find('.subcategory-editor-subcategory');
                        if (next_subcategory.length) next_subcategory.click().find('input').caret(0);
                        else if ($t.val()) ed.click();
                        else return; // allow tabbing to next element
                        return false;
                    }
                }
                // del key
                else if (e.which == 46 && (!$.trim($t.val()) || ($t.caret() == $t.val().length))) {
                    var next_subcategory = $t.closest('li').next('li').find('.subcategory-editor-subcategory');
                    if (next_subcategory.length) next_subcategory.click().find('input').caret(0);
                    else if ($t.val()) ed.click();
                    return false;
                }
                // enter key
                else if (e.which == 13) {
                    ed.trigger('click', [$t.closest('li').next('li').find('.subcategory-editor-subcategory')]);

                    // trigger blur if maxsubcategories limit is reached
                    if (o.maxSubcategories && ed.data('subcategories').length >= o.maxSubcategories) ed.find('input').blur();

                    return false;
                }
                // pos1
                else if (e.which == 36 && !$t.caret()) ed.find('.subcategory-editor-subcategory').first().click();
                // end
                else if (e.which == 35 && $t.caret() == $t.val().length) ed.find('.subcategory-editor-subcategory').last().click();
                // esc
                else if (e.which == 27) {
                    $t.val($t.data('old_subcategory') ? $t.data('old_subcategory') : '').blur();
                    return false;
                }
            });

            // create initial subcategories
            var subcategories = o.initialsubcategories.length ? o.initialsubcategories : el.val().split(o.dregex);
            for (var i=0; i<subcategories.length; i++) {
                if (o.maxSubcategories && i >= o.maxSubcategories) break;
                var subcategory = $.trim(subcategories[i].replace(/ +/, ' '));
                if (subcategory) {
                    if (o.forceLowercase) subcategory = subcategory.toLowerCase();
                    subcategory_list.push(subcategory);
                    ed.append('<li><div class="subcategory-editor-spacer">&nbsp;'+o.delimiter[0]+'</div><div class="subcategory-editor-subcategory">'+escape(subcategory)+'</div><div class="subcategory-editor-delete"><i></i></div></li>');
                }
            }
            update_globals(true); // true -> no onChange callback

            // init sortable
            if (o.sortable && $.fn.sortable) ed.sortable({
                distance: 5, cancel: '.subcategory-editor-spacer, input', helper: 'clone',
                update: function(){ update_globals(); }
            });
        });
    };

    $.fn.subcategoryEditor.defaults = {
        initialBlogSubcategories: [],
        maxSubcategories: 0,
        maxLength: 50,
        delimiter: ',;',
        placeholder: '',
        forceLowercase: true,
        removeDuplicates: true,
        clickDelete: false,
        animateDelete: 175,
        sortable: true, // jQuery UI sortable
        autocomplete: null, // options dict for jQuery UI autocomplete

        // callbacks
        onChange: function(){},
        beforesubcategoriesave: function(){},
        beforesubcategoryDelete: function(){}
    };
}(jQuery));
