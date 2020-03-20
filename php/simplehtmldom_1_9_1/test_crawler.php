#!/usr/local/bin/php
<?php
    include('simple_html_dom.php');
    function crawlerWithYears(string $url, int $year_birth, int $year_build) {
        $request = array(
            'http' => array(
                'method' => 'POST',
                'content' => http_build_query(array(
                    'year_birth' => $year_birth,
                    'year_build' => $year_build
                )),
            )
        ); 
        $context = stream_context_create($request);
        $html = file_get_html($url, false, $context);
        $class_find = '#boiaicap';
        $body_data = $html ->find($class_find,0);
        return $body_data;
    }

    $url = 'http://www.tracuuphongthuy.com/xem-tuoi-xay-nha.html';
    for ($year_birth = 1970; $year_birth <= 2020; $year_birth++) {
        for ($year_build = 2020; $year_build <= 2040; $year_build++) {
            echo 'results: ';
            echo $year_birth,'-', $year_build, "\r\n";
            file_put_contents('results/sinh_nam_'.$year_birth.'_xay_nam_'.$year_build.'.html', crawlerWithYears($url, $year_birth, $year_build));
            echo('--------------OK-------------------');
        }
    }
?>